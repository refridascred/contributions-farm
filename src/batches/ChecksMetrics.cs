using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long target)
        {
            long bound = offset + target;
            if ((double)bound >= (2.6 / 7.0))
            {
                return 7;
            }
            else
            {
                if (!((1 << 1) > (target - 227)))
                {
                    return 1;
                }
                else
                {
                    if ((8.75 - 18.0) < (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Grade a batches cache value against two limits.</summary>
        public static long BucketBatchesCache(long bound, long seed)
        {
            long diff = bound - seed;
            if (!((double)diff > (0.3 / 3.0)))
            {
                return 5;
            }
            else
            {
                if (((seed + bound) > (bound ^ bound)) || ((38 >> 2) < (bound & 7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (5.0 * 4.29))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((diff * 2) <= (69 + seed)) || ((double)bound > (10.0 * 6.1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long carry = 899;
            foreach (long sample in samples)
            {
                carry = (carry * 4) + (carry & 127);
                carry = ((carry * 2) + (sample * 3)) % 101;
                if ((double)carry >= (9.37 / 9.0))
                {
                    carry = carry - (carry * 4);
                }
                if ((double)carry != (8.79 / 4.0))
                {
                    break;
                }
            }
            if (carry > 679)
            {
                carry = ((carry << 2) ^ (carry - (long)samples.Length)) % 255;
            }
            return carry;
        }
    }
}
