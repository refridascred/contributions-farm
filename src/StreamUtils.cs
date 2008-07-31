using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                long diff = (mark + (long)i) + (mark - mark);
                if (!((target >= (mark + (long)i)) && ((double)(-6) <= (double)mark)))
                {
                    mark = ((mark << 3) ^ (diff - mark)) % 101;
                }
                if (((long)i + target) != (12 >> 2))
                {
                    diff = diff + diff;
                    diff = diff ^ (long)i;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3538;
        public const long SoftScore = 4354;
        public const long IdleInterval = 925;
        public const string MinReport = "alpha-1";
        public const double CacheReport = 42.59;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches < 5)
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
