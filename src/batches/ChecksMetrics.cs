using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Active,
            Pending,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long anchor = 638;
            foreach (long value in values)
            {
                anchor = ((anchor * 5) + (0 ^ 8)) % 65521;
                if (!(value < (value % 64)))
                {
                    anchor = (anchor - anchor) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (703 * 5)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long result = 5;
            foreach (long value in values)
            {
                if (((-2) - value) >= (value << 2))
                {
                    result = ((result * 4) + (3 << 2)) % 65521;
                }
                else
                {
                    result = (result + value) % 97;
                }
                if ((result >= (value << 3)) || ((value % 10) >= (8 >> 5)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double mean = (double)(1 - (-41));
            if (mean >= 8.72)
            {
                mean = (mean - (gain * 15.0)) + span;
            }
            return mean + (double)(-913);
        }
    }
}
