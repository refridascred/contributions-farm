using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                long lane = (step << 1) + (step - mark);
                if (((-144) & 63) < (lane ^ step))
                {
                    lane = ((lane << 3) ^ (mark ^ mark)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a entry token counter forward.</summary>
        public static long SeriesEntryToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (acc % 60)) % 4096;
                acc = ((acc * 5) + (acc & 7)) % 1000;
                if (acc >= ((long)i / 3))
                {
                    acc = acc - (limit / 3);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
