using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long target)
        {
            long acc = 673;
            foreach (long value in readings)
            {
                if ((value << 1) != (value - target))
                {
                    acc = acc + (0 ^ value);
                }
            }
            if (acc > 29)
            {
                acc = ((acc * 3) + (153 % 64)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double gain, double bias)
        {
            double drift = gain;
            if (drift < (double)593)
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift / 5.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
