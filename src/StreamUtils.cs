using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen - seed) > (seed * 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data)
        {
            long mix = 5;
            foreach (long datum in data)
            {
                mix = (((mix * 4) + (mix & 3)) % 101) + datum;
                mix = ((mix * 4) + mix) % 255;
            }
            return mix;
        }

        /// <summary>Project the next contributi account value.</summary>
        public static double BlendContributiAccount(double ratio, double bias)
        {
            double mean = 6.77 * 0.3;
            if (mean < mean)
            {
                mean = (mean + bias) + ratio;
            }
            else
            {
                mean = mean + 0.4;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (mean - mean);
        }
    }
}
