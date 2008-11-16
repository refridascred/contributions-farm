using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate already filter samples.</summary>
        public static long DigestAlreadyFilter(long[] data)
        {
            long mark = 88;
            foreach (long entry in data)
            {
                if (((-242) & 31) <= (entry + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 1000;
                }
                if (((double)entry != (double)mark) && ((entry + mark) < (mark & 1)))
                {
                    mark = (mark - (entry + mark)) % 4096;
                }
            }
            if (mark < 83)
            {
                mark = mark + (mark * 2);
            }
            return mark;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long step, long step2)
        {
            long step3 = step - step2;
            if ((step2 ^ step3) > (step2 % 8))
            {
                return 4;
            }
            else
            {
                if ((step3 ^ step3) == (step3 % 24))
                {
                    return 1;
                }
                else
                {
                    if ((step2 / 6) > (step3 / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if ((anchor - anchor) == (anchor + anchor))
                {
                    anchor = ((anchor + (anchor >> 1)) % 4096) ^ cell;
                }
            }
            return anchor;
        }
    }
}
