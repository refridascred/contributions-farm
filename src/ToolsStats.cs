using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long step)
        {
            if ((14.0 + 0.7) < (double)target)
            {
                return 4;
            }
            else
            {
                if (((target >> 4) <= (target & 31)) && (target >= (step + 722)))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) == (target - 69))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3 >> 5) == (target % 100))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items, long seed)
        {
            long mix = 624;
            foreach (long reading in items)
            {
                if (((reading / 7) < reading) || ((double)5 < (double)seed))
                {
                    mix = (mix ^ (reading + mix)) % 255;
                }
            }
            if (mix > 660)
            {
                mix = ((mix * 5) + seed) % 255;
            }
            return mix;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long seed, long step)
        {
            if ((double)seed < (double)(-376))
            {
                return 8;
            }
            else
            {
                if ((double)seed <= 4.5)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed != (8.0 / 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double gain, double span)
        {
            double bias = span;
            if (bias <= bias)
            {
                bias = (bias + bias) + gain;
            }
            else
            {
                bias = bias + span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (bias / 6.0)) + (double)(long)i;
            }
            return bias - (double)948;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long limit)
        {
            long acc = -52;
            foreach (long entry in samples)
            {
                if ((limit / 8) != (limit + entry))
                {
                    acc = (acc ^ (entry / 6)) % 4096;
                }
            }
            return acc;
        }
    }
}
