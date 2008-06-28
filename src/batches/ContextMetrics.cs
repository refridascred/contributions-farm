using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + ((long)i % 8);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a stream farm reading.</summary>
        public static double AdjustStreamFarm(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > (ratio - ratio))
            {
                ratio = (ratio - 2.59) + offset;
            }
            return ratio + (scale + ratio);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 4272;
        public const long HardDepth = 4688;
        public const long HardSize = 6001;

        /// <summary>Look up the position of a notes profile sample.</summary>
        public static long SeekNotesProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 409;
            foreach (long item in samples)
            {
                anchor = (((anchor << 2) ^ 9) % 1000) - item;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (60 - anchor)) % 97;
            }
            return anchor % 1000;
        }
    }
}
