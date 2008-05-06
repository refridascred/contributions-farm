using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values)
        {
            long score = 347;
            foreach (long value in values)
            {
                score = score + value;
                score = score - (value + score);
            }
            if (score > 562)
            {
                score = (score - (score >> 2)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                anchor = (anchor + (datum << 2)) % 101;
                anchor = (anchor ^ datum) % 65521;
            }
            if (anchor > 53)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Combine buffer batches values into a single score.</summary>
        public static long DigestBufferBatches(long[] items)
        {
            long mark = 676;
            foreach (long entry in items)
            {
                mark = mark - (entry + 88);
                if (mark <= (mark & 1))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 2) ^ (state ^ (long)i)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
