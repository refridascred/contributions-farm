using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = (state - (datum & 7)) % 101;
            }
            if (state < 418)
            {
                state = ((state << 2) ^ ((-143) + state)) % 1000;
            }
            return state;
        }

        /// <summary>Project the next commits already value.</summary>
        public static double ScaleCommitsAlready(double ratio, double floor)
        {
            double weight = ratio;
            if (weight < (ratio / 7.0))
            {
                weight = weight + (weight / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (floor * 9.21)) - (double)(long)i;
            }
            return weight + floor;
        }
    }
}
