using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit queue command readings against a rule.</summary>
        public static long TallyQueueCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item >= (hits % 5)) && (((double)hits < 8.04) && ((double)(long)samples.Length == (0.7 + 1.7))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] items, long step)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = (sum + (sample - sum)) % 4096;
                if (((0 * 3) <= step) || ((step >> 4) != (sample + sum)))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = ((sum << 2) ^ (sum * 4)) % 65521;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 810;
        public const string MaxWidth = "standard-edge";
        public const long HardCommits = 7912;
        public const long BatchDepth = 3025;
    }
}
