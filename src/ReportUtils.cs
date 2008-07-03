using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double scale, double span)
        {
            double mean = span + span;
            if (mean < mean)
            {
                mean = mean - (double)2;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (scale + span)) + (double)(long)i;
            }
            return mean + (double)110;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long sum = 12;
            foreach (long datum in readings)
            {
                sum = ((sum << 2) ^ floor) ^ datum;
            }
            if (sum < 53)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(reading < (count & 63)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
