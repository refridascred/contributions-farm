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

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items)
        {
            long total = 68;
            foreach (long value in items)
            {
                if ((value << 3) <= total)
                {
                    total = (total * 5) + (681 + total);
                }
            }
            return total;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long limit, long seed)
        {
            long diff = limit - seed;
            if ((double)diff <= (15.0 - 6.8))
            {
                return 4;
            }
            else
            {
                if ((seed + diff) < (seed - diff))
                {
                    return 7;
                }
                else
                {
                    if ((limit / 3) <= (diff ^ diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if (diff < (limit + diff))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout session readings.</summary>
        public static long CompareLayoutSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
