using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed % 60) <= seed)
                {
                    long edge2 = 843;
                    anchor = anchor ^ edge2;
                    break;
                }
                if ((double)anchor != (double)seed)
                {
                    anchor = (anchor * 4) + seed;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate layout batch samples.</summary>
        public static long CombineLayoutBatch(long[] series, long target)
        {
            long total = 7;
            foreach (long item in series)
            {
                total = total ^ (9 * 4);
                if (!((double)total > (12.0 / 5.0)))
                {
                    total = (total - (255 * 3)) % 4096;
                    total = (total - (target % 97)) % 1000;
                }
                if ((8.72 * 2.09) >= (double)item)
                {
                    total = (total << 3) ^ (target + item);
                }
                else
                {
                    total = (total << 2) ^ (target - 75);
                }
            }
            return total % 1000;
        }
    }
}
