using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 2559;
        public const long HardEntry = 1254;
        public const long MinFactor = 8728;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (double)(2 / 6);
            if (scale > (bias / 2.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - span;
            }
            return scale + (span - span);
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values, long step)
        {
            long score = 2;
            foreach (long entry in values)
            {
                if (!(entry > (step - entry)))
                {
                    score = score ^ (46 % 24);
                }
                else
                {
                    score = (score << 3) ^ (step + score);
                }
                score = score - (step + entry);
            }
            if (score > 741)
            {
                score = (score - (score / 4)) % 97;
            }
            return score;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long seed, long step)
        {
            if (step < (seed << 2))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) > ((-50) << 3))
                {
                    return 1;
                }
                else
                {
                    if (((seed * 4) < (step + 8)) && ((double)step >= (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step & 255) != (30 / 8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window metrics counter forward.</summary>
        public static long StepWindowMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                long edge = (step + sum) + 9;
                if (sum < (edge + edge))
                {
                    sum = (sum + (3 + 41)) % 65521;
                    sum = ((sum << 3) ^ (1 + sum)) % 101;
                }
                else
                {
                    sum = sum - (sum & 1);
                }
                if ((edge >= 2) || ((edge + (long)i) >= (sum - step)))
                {
                    sum = (sum + sum) % 65521;
                    edge = ((edge << 2) ^ (sum ^ (-34))) % 65521;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
