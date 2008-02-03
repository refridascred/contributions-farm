using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long ScoreStatsAlready(long[] readings)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                if (reading <= (reading * 3))
                {
                    mark = mark - (mark - mark);
                }
            }
            return mark;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples, long offset)
        {
            long mix = -2;
            foreach (long reading in samples)
            {
                mix = ((mix << 3) ^ (reading - mix)) - offset;
                if (((double)mix > 8.04) || ((reading << 2) < mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double span)
        {
            double bias = (span / 9.0) - ratio;
            return bias + (ratio * 9.81);
        }
    }
}
