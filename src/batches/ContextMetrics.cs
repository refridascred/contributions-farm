using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum + (long)i) % 1000;
                sum = sum + (890 ^ origin);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (9.7 >= (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Audit editor checks readings against a rule.</summary>
        public static long AuditEditorChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally & 255) != (value + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if (((2.1 / 5.0) == (double)offset) && ((bound ^ bound2) > (offset % 3)))
            {
                return 8;
            }
            else
            {
                if ((bound2 & 127) <= (bound + offset))
                {
                    return 2;
                }
                else
                {
                    if ((72 - bound) != (bound2 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound < (bound + 629)) && ((double)770 >= (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
