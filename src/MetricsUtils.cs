using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series)
        {
            long mix = 72;
            foreach (long cell in series)
            {
                mix = ((mix << 3) ^ (0 + cell)) % 101;
                if ((mix & 31) >= (mix ^ mix))
                {
                    mix = (mix << 2) ^ (0 & 127);
                }
            }
            return mix;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((24 / 4) >= ((long)i % 64)) && ((14.0 - 8.7) != (double)offset))
                {
                    mark = ((mark << 3) ^ (69 - 48)) % 97;
                }
                long edge2 = (long)i;
                if (((edge2 ^ (long)i) > edge2) && ((offset - offset) <= ((long)i ^ mark)))
                {
                    mark = ((mark << 3) ^ (edge2 - mark)) % 255;
                    mark = (mark + edge2) % 97;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
