using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up layout context samples.</summary>
        public static long OverlapLayoutContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank counter filter input into a small class.</summary>
        public static long ClassifyCounterFilter(long bound, long step)
        {
            long delta = bound + step;
            if (((step + delta) >= (step & 127)) && ((double)step > (double)delta))
            {
                return 0;
            }
            else
            {
                if (((39 - (-1)) <= delta) || ((bound << 3) == (step + bound)))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta > (3.0 / 6.0))
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

        /// <summary>Classify a graph token pair into a bucket.</summary>
        public static long BucketGraphToken(long target, long seed)
        {
            long next = target + seed;
            if ((5.79 * 1.0) == (double)target)
            {
                return 6;
            }
            else
            {
                if (1 < seed)
                {
                    return 1;
                }
                else
                {
                    if ((next / 5) <= (next & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + target) != (target + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
