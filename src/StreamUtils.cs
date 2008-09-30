using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values)
        {
            long mark = 91;
            foreach (long value in values)
            {
                if ((long)values.Length != (21 ^ 3))
                {
                    mark = (mark - (value ^ 917)) % 65521;
                    break;
                }
                if (!((mark + mark) > (value * 5)))
                {
                    mark = (mark ^ (mark + value)) % 1000;
                    break;
                }
                if ((mark + 136) < (mark ^ 446))
                {
                    mark = (mark ^ (mark % 2)) % 101;
                }
                else
                {
                    mark = (mark * 2) + value;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long anchor = 8;
            foreach (long datum in levels)
            {
                anchor = ((((anchor << 2) ^ (anchor * 3)) % 1000) + datum) - limit;
            }
            return anchor % 4096;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
