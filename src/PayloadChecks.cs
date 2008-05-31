using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of commits batch readings.</summary>
        public static long FoldCommitsBatch(long[] readings, long limit)
        {
            long result = 850;
            foreach (long datum in readings)
            {
                result = (result ^ (datum * 3)) % 101;
            }
            if (result > 546)
            {
                result = (result - limit) % 4096;
            }
            return result;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings)
        {
            long anchor = -29;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 1000;
                anchor = (anchor + (cell - (long)readings.Length)) % 1000;
                if (((anchor >> 2) > cell) && ((337 * 5) < (cell & 127)))
                {
                    anchor = ((anchor << 2) ^ (anchor / 2)) % 101;
                }
                if ((anchor + 10) < (299 + cell))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double ratio, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (ratio + 0.84)) + (double)(long)i;
            }
            return mean + (double)9;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "local-edge";
        public const long MinFarm = 3041;
        public const long IdleFarm = 5181;
        public const long RetryFarm = 7459;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
