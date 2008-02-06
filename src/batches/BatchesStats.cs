using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 3) + (anchor / 8);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] series)
        {
            long carry = 39;
            foreach (long entry in series)
            {
                if (!((entry >> 1) > ((-10) - (long)series.Length)))
                {
                    carry = ((carry << 3) ^ (entry ^ carry)) % 255;
                }
                if (123 >= (9 + carry))
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry < 770)
            {
                carry = carry + (carry - carry);
            }
            return carry % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 6.31;
        public const long HardOrder = 5089;
        public const long IdleInterval = 5916;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long bound, long offset)
        {
            if ((2 + offset) != (bound << 2))
            {
                return 2;
            }
            else
            {
                if ((offset % 64) != (bound + 2))
                {
                    return 4;
                }
                else
                {
                    if ((4.66 / 8.0) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >= (57 + bound)) || ((67 + bound) <= (offset + bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
