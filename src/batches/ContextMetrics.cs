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

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double mean = gain;
            if (mean >= 9.2)
            {
                mean = mean - (1.0 + offset);
            }
            else
            {
                mean = mean - gain;
            }
            return mean - offset;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (double)matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
