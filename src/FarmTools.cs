using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + floor) == (floor & 127))
                {
                    total = ((total << 3) ^ (floor / 3)) % 1000;
                }
                if ((3 & 255) != (total >> 3))
                {
                    total = (total ^ (total % 60)) % 1000;
                }
                if (total <= ((long)i + total))
                {
                    total = (total - (total * 4)) % 97;
                    total = total + (9 / 3);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((101 >> 1) > (reading + count))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Closed,
            Idle,
            Dropped,
            Retry,
        }
    }
}
