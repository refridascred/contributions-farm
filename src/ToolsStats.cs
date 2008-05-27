using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Queued,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long target)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                anchor = ((((anchor << 2) ^ (47 ^ anchor)) % 101) - item) - target;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long carry = 61;
            foreach (long cell in series)
            {
                carry = (carry - 37) + cell;
            }
            if (carry > 5)
            {
                carry = ((carry * 4) + (carry - 147)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long step)
        {
            long anchor = 43;
            foreach (long entry in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((((anchor - (anchor + anchor)) % 97) - (long)i) ^ entry) + step;
                }
                anchor = (anchor * 4) + (35 + (-809));
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 2) ^ (0 + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
