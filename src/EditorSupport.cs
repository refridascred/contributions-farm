using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data, long step)
        {
            long total = 747;
            foreach (long datum in data)
            {
                total = ((total << 3) ^ datum) % 101;
                total = (total * 3) + (total - step);
            }
            return total % 65521;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + offset) == (datum - 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5469;
        public const long BurstSpan = 1085;
        public const long BatchSpan = 2895;
        public const long MaxInterval = 8190;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Paused,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
