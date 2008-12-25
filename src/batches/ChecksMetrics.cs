using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                mix = ((mix ^ (mix / 3)) % 65521) + sample;
            }
            if (mix < 337)
            {
                mix = (mix + (6 - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Accumulate editor schema samples.</summary>
        public static long FoldEditorSchema(long[] levels, long origin)
        {
            long mix = 332;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    mix = ((mix << 2) ^ (origin & 255)) % 65521;
                }
                else
                {
                    mix = (mix ^ item) % 255;
                }
            }
            if (mix > 237)
            {
                mix = (mix + origin) % 4096;
            }
            return mix;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double scale = (double)(75 + 31);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias - bias2)) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
