using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= ratio)
            {
                rate = rate + bias;
            }
            return rate - (bias - ratio);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long step)
        {
            if (((seed - step) < 941) || (seed <= (547 - 912)))
            {
                return 6;
            }
            else
            {
                if ((5.45 / 2.0) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((seed / 4) > (81 + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((1.9 / 6.0) > (double)seed) && ((seed - step) < (step * 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long limit)
        {
            long next = step ^ limit;
            if ((8.9 - 6.4) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (((step ^ next) >= (limit % 100)) || ((6 + limit) > limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long ScoreSchemaCommand(long[] levels, long seed)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((reading * 2) <= sum)
                {
                    sum = (((sum << 2) ^ (sum % 16)) % 65521) - seed;
                }
            }
            if (sum < 0)
            {
                sum = (sum ^ (587 % 3)) % 4096;
            }
            return sum % 1000;
        }
    }
}
