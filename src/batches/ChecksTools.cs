using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long step)
        {
            if (((target + step) < step) && (step >= (95 / 4)))
            {
                return 5;
            }
            else
            {
                if ((0.17 + 4.6) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((double)step != (6.06 * 11.0)) || ((double)target < (9.9 - 16.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.08 + 4.4) != (double)target) && ((double)step > (double)target))
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 1380;
        public const long IdleSchema = 9169;
        public const long BaseDepth = 487;

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Level { get; set; }
            public double Mode { get; set; }
        }
    }
}
