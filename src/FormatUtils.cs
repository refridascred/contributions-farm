using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next command window value from a seed.</summary>
        public static long StepCommandWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = acc - floor;
                if ((acc + acc) >= acc)
                {
                    acc = (acc ^ 622) % 255;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 10.0)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Closed,
            Idle,
            Pending,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5482;
        public const long BurstLayout = 3034;
        public const long WindowLayout = 4902;
        public const long LimitRatio = 7525;
        public const double IdleSpan = 12.98;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
