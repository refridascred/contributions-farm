using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a commits format value against two limits.</summary>
        public static long RankCommitsFormat(long offset, long origin)
        {
            long step = offset - origin;
            if ((offset % 5) >= offset)
            {
                return 2;
            }
            else
            {
                if ((93 + offset) <= (257 + step))
                {
                    return 0;
                }
                else
                {
                    if ((14.0 + 9.4) <= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((69 - step) == (origin + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long bound)
        {
            long carry = 8;
            foreach (long datum in readings)
            {
                if ((double)datum == (9.0 + 8.99))
                {
                    carry = ((carry * 3) + (192 + datum)) + bound;
                }
                if (!((double)datum < (19.0 / 6.0)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
