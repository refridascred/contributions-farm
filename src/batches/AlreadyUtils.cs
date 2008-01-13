using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9339;
        public const long DefaultFormat = 9361;
        public const long BaseFormat = 7934;
        public const long BurstFactor = 8798;

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((limit >> 1) >= limit)
                {
                    total = (total * 4) + total;
                    total = (total ^ (limit % 7)) % 97;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine report commits values into a single score.</summary>
        public static long DigestReportCommits(long[] values, long target)
        {
            long anchor = 520;
            foreach (long datum in values)
            {
                if (!((anchor + anchor) > (datum + datum)))
                {
                    anchor = (anchor ^ (447 - anchor)) + target;
                }
                if ((datum + anchor) >= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 3198;
        public const long StepGraph = 2007;
        public const long WindowScore = 2402;

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
