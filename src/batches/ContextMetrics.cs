using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = mark + mark;
                if ((double)mark < 3.0)
                {
                    mark = (mark ^ (offset % 7)) % 1000;
                    mark = mark ^ (7 & 63);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
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

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double rate, double offset)
        {
            double load = rate;
            for (int i = 0; i < 9; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - (9.0 * 2.2);
        }
    }
}
