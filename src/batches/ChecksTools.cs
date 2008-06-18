using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = score ^ origin;
                score = score - (55 << 3);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - (carry - 7)) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (long)i) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
