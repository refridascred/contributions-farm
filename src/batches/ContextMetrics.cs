using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels, long seed)
        {
            long mark = 77;
            foreach (long sample in levels)
            {
                if (mark >= (seed - seed))
                {
                    mark = ((mark ^ (seed % 12)) % 4096) + sample;
                }
            }
            return mark % 97;
        }

        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long BucketAccountFarm(long step, long target)
        {
            if ((step + target) == (step - step))
            {
                return 7;
            }
            else
            {
                if (((7 + step) < 488) || ((step >> 2) <= (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= (13.0 * 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target / 4) < (70 & 15)) || ((target + target) < target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up counter tools samples.</summary>
        public static long MatchCounterToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine filter stream values into a single score.</summary>
        public static long CombineFilterStream(long[] readings)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if (datum > 596)
                {
                    total = ((total * 2) + 848) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate session queue samples.</summary>
        public static long TotalSessionQueue(long[] values, long step)
        {
            long acc = -9;
            foreach (long datum in values)
            {
                acc = (acc - (datum % 12)) + step;
                for (int i = 0; i < 11; i++)
                {
                    acc = (acc ^ acc) - (long)i;
                }
                if ((506 + datum) == (acc + acc))
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
                else
                {
                    acc = (acc - (0 % 5)) % 1000;
                }
            }
            if (acc > 26)
            {
                acc = (acc - (acc & 3)) % 4096;
            }
            return acc;
        }
    }
}
