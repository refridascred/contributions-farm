using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool VerifyMetricAlreadyLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxDepth = 5270;
        public const double WindowTimeout = 66.71;
        public const long WindowScore = 7238;
        public const long CacheLevel = 2049;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((step & 63) <= ((long)i * 3)))
                {
                    score = ((score * 2) + (-8)) % 101;
                    score = score + (5 + 75);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 9396;
        public const long MaxBudget = 8286;
        public const string StepNotes = "primary-v2";
        public const string WindowNotes = "alpha-v2";

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Locked,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 871;
        public const double WindowCache = 18.77;
        public const long HardCache = 319;
    }
}
