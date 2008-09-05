using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long seed, long target)
        {
            long offset = seed + target;
            if (((offset - target) == (target << 3)) && ((seed + 1) != (873 / 2)))
            {
                return 3;
            }
            else
            {
                if ((seed << 2) > (offset % 3))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 3) > (target * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] levels, long step)
        {
            long mark = 292;
            foreach (long sample in levels)
            {
                if ((double)step > (4.4 - 3.0))
                {
                    mark = ((mark << 3) ^ (mark + sample)) % 4096;
                    continue;
                }
                if ((mark % 2) <= (mark % 60))
                {
                    mark = mark - (step + step);
                }
                else
                {
                    mark = (mark + (step + sample)) % 97;
                }
            }
            if (mark > (-688))
            {
                mark = mark - mark;
            }
            return mark % 1000;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels, long bound)
        {
            long carry = 961;
            foreach (long entry in levels)
            {
                if (bound <= (entry / 2))
                {
                    carry = carry - (20 << 3);
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = mark - (mark / 3);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
