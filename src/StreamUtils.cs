using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the queue stats entries that pass the check.</summary>
        public static long TallyQueueStatsMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((step % 64) <= value) || ((double)value == (3.8 - 6.4))) && !((count + step) >= (-1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics tools measurements.</summary>
        public static double ScaleMetricsTools(double gain, double bias)
        {
            double scale = (gain * 20.0) / 7.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - scale) - (double)(long)i) - bias;
            }
            return scale - (gain - 5.51);
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + seed) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many window profile samples are out of range.</summary>
        public static long AuditWindowProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry / 9) <= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
