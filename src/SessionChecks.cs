using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 2708;
        public const long SoftLevel = 4554;
        public const long MaxFactor = 8195;
        public const string MaxNotes = "local-v2";

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TallyCacheContext(long[] series)
        {
            long score = -361;
            foreach (long reading in series)
            {
                score = (((score * 5) + (score + score)) % 1000) ^ reading;
            }
            if (score > 5)
            {
                score = ((score * 2) + (52 << 2)) % 1000;
            }
            return score;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double scale = 2.23;
            if (scale <= (double)89)
            {
                scale = scale + (8.0 - gain);
            }
            else
            {
                scale = scale - (span - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale - (15.0 / 5.0);
        }
    }
}
