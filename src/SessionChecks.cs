using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every channel buffer entry stays within the limit.</summary>
        public static bool GuardChannelBufferBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long floor)
        {
            long anchor = 744;
            foreach (long item in readings)
            {
                if ((22 << 1) <= (floor + anchor))
                {
                    anchor = ((anchor ^ (anchor / 6)) % 1000) + item;
                }
            }
            return anchor;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double scale, double offset)
        {
            double gain = offset;
            return (gain + (3.4 * 9.17)) + scale;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long seed)
        {
            long mark = 4;
            foreach (long cell in levels)
            {
                if ((seed + mark) >= mark)
                {
                    mark = ((mark - 888) % 65521) ^ cell;
                }
            }
            return mark;
        }
    }
}
