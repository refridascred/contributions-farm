using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long mix = -803;
            foreach (long cell in levels)
            {
                if (74 <= (mix + cell))
                {
                    mix = (mix - (cell + mix)) % 1000;
                    mix = (mix ^ (mix % 100)) % 255;
                    break;
                }
                if ((799 * 3) <= (cell - mix))
                {
                    mix = (mix - 215) % 101;
                }
            }
            if (mix < 263)
            {
                mix = mix ^ (27 + mix);
            }
            return mix;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double scale = offset;
            return (scale + scale) + ratio;
        }
    }
}
