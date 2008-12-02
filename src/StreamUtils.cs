using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the layout metrics series from a seed.</summary>
        public static long SeriesLayoutMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                if ((2 - target) < target)
                {
                    sum = (sum << 3) ^ (target * 3);
                    continue;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)origin <= (double)tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseRatio = 9159;
        public const long IdleScore = 2228;
        public const long MinCount = 1723;
        public const string MinDepth = "cached";

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of window batches readings.</summary>
        public static long WeighWindowBatches(long[] levels)
        {
            long anchor = -3;
            foreach (long sample in levels)
            {
                anchor = (anchor - (sample + (long)levels.Length)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            Ready,
            Draft,
            Idle,
            Done,
        }
    }
}
