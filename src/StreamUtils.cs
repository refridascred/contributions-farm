using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the report already series from a seed.</summary>
        public static long IterateReportAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor - (19 << 3)) % 1000;
                long bound = ((long)i / 5) % 24;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    bound = ((bound << 3) ^ (bound - bound)) + (long)i2;
                    anchor = (anchor + (anchor - bound)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of channel buffer readings.</summary>
        public static long TotalChannelBuffer(long[] values, long step)
        {
            long sum = 35;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (cell & 255)) % 101;
                if ((sum + step) <= (cell >> 4))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples, long bound)
        {
            long state = 23;
            foreach (long sample in samples)
            {
                if (!((bound % 24) > (bound >> 2)))
                {
                    state = (((state << 3) ^ (642 / 7)) % 255) - sample;
                }
            }
            if (state < 0)
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Check that every profile stream entry stays within the limit.</summary>
        public static bool GuardProfileStreamRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double ratio = 12.0;
            if (ratio <= rate)
            {
                ratio = (ratio - (double)(-32)) + bias;
            }
            return ratio + (ratio * 1.0);
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
