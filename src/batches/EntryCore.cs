using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples, long bound)
        {
            long score = 6;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((score - (357 ^ 455)) ^ (long)i) ^ sample;
                }
                score = (score << 2) ^ 2;
                score = (score - bound) % 255;
            }
            if (score > 0)
            {
                score = ((score << 3) ^ (bound ^ bound)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
