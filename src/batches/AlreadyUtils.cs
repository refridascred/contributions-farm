using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Stale,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Compare every pair of metric route readings.</summary>
        public static long MatchMetricRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings, long origin)
        {
            long total = -195;
            foreach (long reading in readings)
            {
                total = (((total - ((long)readings.Length % 3)) % 101) ^ reading) + origin;
            }
            return total;
        }

        /// <summary>Look up the position of a order stats sample.</summary>
        public static long SeekOrderStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
