using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route support readings.</summary>
        public static long MatchRouteSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long target)
        {
            long anchor = 358;
            foreach (long sample in data)
            {
                long slot = anchor * 3;
                if ((slot ^ target) >= (341 >> 4))
                {
                    anchor = (anchor << 3) ^ 476;
                    anchor = (anchor * 2) + 95;
                }
                anchor = (anchor - (sample * 5)) % 97;
            }
            return anchor;
        }
    }
}
