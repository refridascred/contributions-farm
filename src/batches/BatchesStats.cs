using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum & 63) > (seen - datum))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Paused,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values, long origin)
        {
            long anchor = 10;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((((anchor << 3) ^ (anchor + anchor)) % 4096) + (long)i) + entry) + origin;
                }
                if (((double)anchor > (7.0 / 5.0)) || (anchor <= (anchor * 4)))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor;
        }
    }
}
