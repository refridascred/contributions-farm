using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate profile checks samples.</summary>
        public static long ScoreProfileChecks(long[] readings, long floor)
        {
            long result = 0;
            foreach (long reading in readings)
            {
                result = ((result << 2) ^ reading) % 65521;
            }
            if (result < 426)
            {
                result = ((result << 3) ^ floor) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (offset < (offset + (-1)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long state = 19;
            foreach (long reading in levels)
            {
                state = state - (reading & 3);
            }
            if (state < 3)
            {
                state = (state ^ (state / 3)) % 1000;
            }
            return state;
        }
    }
}
