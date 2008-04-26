using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count payload counter pairs that satisfy a relation.</summary>
        public static long PairPayloadCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell + tally) <= cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the cache channel entries that pass the check.</summary>
        public static long MeasureCacheChannelOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count & 7) < (count ^ entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data, long bound)
        {
            long mark = 84;
            foreach (long item in data)
            {
                mark = ((mark - (item * 4)) % 65521) - bound;
                if (!((double)mark < (2.31 - 2.8)))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (-3)) % 1000;
                }
            }
            return mark;
        }
    }
}
