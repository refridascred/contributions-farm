using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long origin, long offset)
        {
            long bound = origin - offset;
            if (((13.0 * 8.13) >= (double)bound) || ((1 + origin) < origin))
            {
                return 3;
            }
            else
            {
                if ((3 % 24) > origin)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long result = 304;
            foreach (long value in series)
            {
                if (result <= 0)
                {
                    result = ((result * 5) + (value << 3)) % 4096;
                }
                if ((result ^ result) != (value ^ 494))
                {
                    break;
                }
            }
            if (result > 140)
            {
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (84 >= (datum << 2))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Synced,
            Paused,
            Pending,
            Closed,
        }
    }
}
