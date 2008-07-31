using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 4793;
        public const long BurstFactor = 1327;
        public const long MaxStream = 9159;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double scale, double bias)
        {
            double bias2 = 5.98;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 + (1.7 + bias)) + (double)(long)i) + scale;
            }
            return bias2 - (bias2 - 7.9);
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long target, long offset)
        {
            long offset2 = target ^ offset;
            if ((offset2 & 1) > (offset2 ^ 6))
            {
                return 4;
            }
            else
            {
                if ((offset / 3) != (offset2 ^ offset))
                {
                    return 7;
                }
                else
                {
                    if (offset >= (533 * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target < (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                long prev = (carry >> 3) + ((long)i / 8);
                carry = ((carry << 3) ^ prev) % 101;
                carry = (carry ^ (prev - (long)i)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
