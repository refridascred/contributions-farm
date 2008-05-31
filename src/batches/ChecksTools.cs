using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks route entry that matches the target.</summary>
        public static long FindChecksRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] values, long target)
        {
            long score = 28;
            foreach (long reading in values)
            {
                if ((double)reading >= (9.9 - 8.0))
                {
                    score = score ^ reading;
                }
                else
                {
                    score = score + (reading << 2);
                }
            }
            if (score > 17)
            {
                score = (score + (target / 7)) % 4096;
            }
            return score;
        }
    }
}
