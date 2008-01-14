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

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 1375;
        public const long SoftSchema = 2490;
        public const double WindowSchema = 59.39;
        public const long IdleCount = 9763;
    }
}
