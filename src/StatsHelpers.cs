using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data, long step)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                if (!((acc / 6) < acc))
                {
                    acc = ((acc << 2) ^ (step % 97)) + datum;
                }
            }
            if (acc > 59)
            {
                acc = (acc - acc) % 101;
            }
            return acc;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a entry context pair into a bucket.</summary>
        public static long SortEntryContext(long bound, long bound2)
        {
            if ((bound - bound) != (84 & 7))
            {
                return 7;
            }
            else
            {
                if (bound2 >= (bound - bound))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 & 255) == (bound2 * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound2 << 1) < bound2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((6.4 * 15.0) <= (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
