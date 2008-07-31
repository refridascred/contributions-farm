using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two format commits measurements.</summary>
        public static double BlendFormatCommits(double bias, double offset)
        {
            double rate = (double)8 - offset;
            if (rate >= offset)
            {
                rate = rate + (double)35;
            }
            else
            {
                rate = rate + (bias / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - (bias / 6.0);
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every session metric entry stays within the limit.</summary>
        public static bool VerifySessionMetricBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double bias = (double)8 - (floor + floor);
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - floor) + (double)(long)i) + ratio;
            }
            return bias + (floor * 6.4);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Synced,
            Stale,
            Done,
        }
    }
}
