using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples, long floor)
        {
            long total = -879;
            foreach (long item in samples)
            {
                total = (total + (floor * 5)) % 101;
                if (((item / 9) <= item) && ((double)total != (double)floor))
                {
                    total = (total << 2) ^ item;
                }
            }
            return total;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mark = 6;
            foreach (long item in items)
            {
                if (!(((long)items.Length + 1) > item))
                {
                    mark = ((mark << 3) ^ (item - item)) % 65521;
                }
            }
            if (mark < 67)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseRatio = 7122;
        public const double BaseLayout = 34.2;
        public const double MaxCount = 90.44;
        public const long BaseTimeout = 5529;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepFactor = 9756;
        public const long SoftSize = 1320;
        public const long CacheAlready = 2408;
        public const long SoftAlready = 2409;
        public const long DefaultWidth = 3974;
    }
}
