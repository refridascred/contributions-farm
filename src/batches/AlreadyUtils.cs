using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 75.69;
        public const double CacheFactor = 47.92;
        public const long HardCount = 4050;
        public const double WindowSupport = 49.19;
        public const long LimitSupport = 4922;

        /// <summary>Locate a entry record reading by value.</summary>
        public static long FindEntryRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer commits readings.</summary>
        public static long TotalBufferCommits(long[] samples)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if (entry >= (entry << 3))
                {
                    result = result - (166 - result);
                }
                if (!(((-74) >> 2) < (entry / 8)))
                {
                    result = (result ^ 4) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result % 97)) % 101;
                }
                if ((entry >> 4) <= (entry - 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 61.04;
        public const long MinNotes = 112;
        public const long MaxBudget = 3321;
        public const long RetryNotes = 3413;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            New,
            Stale,
        }
    }
}
