using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long mix = 61;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix ^ (sample >> 3)) % 4096) ^ (long)i;
                    mix = (mix + (sample / 6)) % 97;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix * 2) + ((long)i2 - (long)i2);
                }
                mix = ((mix * 5) + (sample + 728)) % 255;
            }
            return mix;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples, long seed)
        {
            long sum = 7;
            foreach (long cell in samples)
            {
                if (seed <= (495 << 1))
                {
                    sum = (sum + sum) + cell;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
            }
            return sum;
        }
    }
}
