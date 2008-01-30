using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long MeasureContributiCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((matches % 3) == (matches << 3)))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context token entries that pass the check.</summary>
        public static long CountContextTokenMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((seed ^ seed) != (150 + seen)) || ((double)seed < (double)0)) || !((seed * 4) < (seen ^ seen)))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen >> 1) == (limit >> 5))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            Pending,
            Done,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
