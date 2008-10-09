using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(((-6) & 255) >= offset))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleFactor = "alpha-1";
        public const string MaxWidth = "strict";
        public const long CacheEditor = 5211;
        public const long BurstEditor = 4031;
        public const long IdleEditor = 9208;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 3908;
        public const long MaxBudget = 9163;
        public const long SoftTimeout = 4340;
        public const long MaxEntry = 3587;
        public const long CacheEntry = 101;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen <= (step ^ step)) && (12.0 < (double)step))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
