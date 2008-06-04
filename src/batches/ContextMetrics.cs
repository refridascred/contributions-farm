using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values, long seed)
        {
            long total = 7;
            foreach (long value in values)
            {
                if ((((long)values.Length / 9) == (seed + seed)) || (seed > (value / 2)))
                {
                    total = (total ^ (value + seed)) % 101;
                }
            }
            return total;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long bound, long step)
        {
            long delta = bound - step;
            if ((1.0 / 8.0) > (double)bound)
            {
                return 8;
            }
            else
            {
                if ((28 ^ step) != (delta & 255))
                {
                    return 0;
                }
                else
                {
                    if (((double)delta == (6.88 / 2.0)) && (684 >= (step * 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (8.39 >= (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] samples)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total ^ (cell >> 1)) + (long)i;
                }
                if (((double)total >= (0.2 + 5.24)) && ((total % 24) <= total))
                {
                    total = (total ^ (74 / 3)) % 255;
                }
                else
                {
                    total = (total + (cell >> 5)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate schema stream samples.</summary>
        public static long WeighSchemaStream(long[] data)
        {
            long sum = 27;
            foreach (long reading in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum + 0) - (long)i;
                }
                sum = ((sum << 3) ^ (sum - reading)) % 255;
            }
            if (sum < 402)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Dropped,
            Queued,
            Synced,
        }
    }
}
