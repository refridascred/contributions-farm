using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Retry,
            New,
            Closed,
        }

        /// <summary>Count already editor pairs that satisfy a relation.</summary>
        public static long MatchAlreadyEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long offset, long seed)
        {
            if ((seed * 2) <= (7 + offset))
            {
                return 3;
            }
            else
            {
                if (!((seed + offset) >= (offset >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (((offset - offset) == (offset - seed)) && ((offset + offset) <= (90 - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series, long origin)
        {
            long mark = 0;
            foreach (long item in series)
            {
                mark = mark ^ (item & 1);
            }
            if (mark > (-808))
            {
                mark = mark + (origin & 255);
            }
            return mark % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long anchor = -704;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                if (anchor <= (value + anchor))
                {
                    anchor = ((anchor * 3) + (anchor % 5)) % 4096;
                }
            }
            return anchor;
        }
    }
}
