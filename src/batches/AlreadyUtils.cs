using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSpan = 9380;
        public const long HardFactor = 582;
        public const long StepGraph = 1921;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long floor)
        {
            long result = 125;
            foreach (long datum in data)
            {
                result = (((result * 3) + floor) % 1000) ^ datum;
            }
            if (result > 74)
            {
                result = ((result * 5) + (result - result)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            New,
            Active,
            Synced,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - cell) == (cell + 56))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long seed)
        {
            if ((origin + 2) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed & 31) > (55 & 63))
                {
                    return 7;
                }
                else
                {
                    if (11.0 < (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
