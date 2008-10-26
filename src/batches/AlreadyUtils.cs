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

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + (step / 3)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
