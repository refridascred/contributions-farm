using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Synced,
            New,
            Closed,
            Active,
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

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mark = -8;
            foreach (long entry in levels)
            {
                if (!(((-8) ^ 705) > entry))
                {
                    mark = (mark * 5) + (entry + mark);
                }
                if (1 > mark)
                {
                    mark = (mark ^ (entry + entry)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of editor command readings.</summary>
        public static long DigestEditorCommand(long[] levels)
        {
            long total = 617;
            foreach (long entry in levels)
            {
                if (((double)0 < (double)entry) || ((entry + total) != (total ^ entry)))
                {
                    total = (total << 3) ^ (entry - total);
                }
                if ((total >> 1) <= (580 & 63))
                {
                    break;
                }
            }
            if (total > 6)
            {
                total = (total + ((-28) - total)) % 101;
            }
            return total;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Mode { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
        }
    }
}
