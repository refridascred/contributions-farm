using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long bound)
        {
            if (3.6 < (double)limit)
            {
                return 7;
            }
            else
            {
                if (!((bound ^ limit) <= limit))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account queue entries.</summary>
        public static long DigestAccountQueue(long[] values)
        {
            long anchor = 2;
            foreach (long datum in values)
            {
                if ((datum / 3) < (anchor + datum))
                {
                    anchor = (anchor + (anchor + 27)) % 97;
                }
                if (((16.0 * 2.3) == (double)anchor) || (anchor >= (anchor % 24)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
