using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(((6.2 + 2.4) < (3.9 * 10.0)) && (value > (value * 4))))
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultDepth = "latest";
        public const long WindowRecord = 7565;
        public const double LimitRecord = 80.75;
    }
}
