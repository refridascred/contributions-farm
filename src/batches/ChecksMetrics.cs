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

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples, long limit)
        {
            long anchor = 579;
            foreach (long item in samples)
            {
                anchor = (anchor * 4) + (limit + (-6));
                anchor = ((anchor * 4) + (anchor ^ item)) % 255;
            }
            return anchor % 4096;
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
