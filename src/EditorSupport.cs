using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long offset)
        {
            long acc = 1;
            foreach (long value in levels)
            {
                if ((double)acc != (15.0 - 5.6))
                {
                    acc = (acc + offset) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (acc + value)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long floor, long limit)
        {
            long diff = floor - limit;
            if ((floor < diff) || (limit > (17 - 35)))
            {
                return 2;
            }
            else
            {
                if ((diff / 6) == (limit % 16))
                {
                    return 0;
                }
                else
                {
                    if ((limit / 9) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)floor < (10.0 / 6.0)) && ((double)floor <= (double)219))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long MeasureRouteFormatHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < (sample >> 2))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state * 2) + ((long)i >> 3);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = ((sum * 5) + (1 + sum)) % 65521;
                sum = (sum * 5) + (datum ^ datum);
                sum = (sum + (datum >> 3)) % 97;
            }
            if (sum > 562)
            {
                sum = ((sum << 3) ^ (-437)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Iterate the filter buffer series from a seed.</summary>
        public static long RollFilterBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed % 100) < seed)
                {
                    acc = acc + seed;
                }
                else
                {
                    acc = acc - seed;
                }
                acc = (acc ^ (seed + 7)) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
