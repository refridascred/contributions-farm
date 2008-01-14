using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardCount = "latest-v2";
        public const long MinSize = 7387;
        public const double MaxSpan = 53.13;
        public const double SoftLevel = 43.18;

        /// <summary>Roll a queue account counter forward.</summary>
        public static long IterateQueueAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ (result << 2);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(((floor & 3) != (matches % 7)) || ((value & 255) >= (value - floor))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank checks buffer input into a small class.</summary>
        public static long ClassifyChecksBuffer(long offset, long seed)
        {
            long slot = offset ^ seed;
            if ((offset >= (slot - slot)) || ((1 - slot) <= slot))
            {
                return 3;
            }
            else
            {
                if ((1.83 * 4.0) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (!((seed & 7) < slot))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
