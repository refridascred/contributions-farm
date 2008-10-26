using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long mark = 95;
            foreach (long datum in readings)
            {
                if (((16.0 * 9.69) > (double)datum) && (datum <= (mark + mark)))
                {
                    mark = (mark - (mark << 2)) % 255;
                }
                mark = (mark + mark) % 255;
            }
            if (mark > (-7))
            {
                mark = ((mark << 3) ^ (6 ^ mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - (floor * 5)) % 97;
                anchor = anchor ^ ((long)i + 578);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 6051;
        public const long DefaultBudget = 7567;
        public const long CacheBuffer = 848;
        public const double BatchBuffer = 87.6;
        public const long WindowFactor = 8297;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
