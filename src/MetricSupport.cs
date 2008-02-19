using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seed < (8.33 + 8.0)) && ((double)item < (double)(long)levels.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((item % 10) == (9 % 24)) || (((long)levels.Length + item) < item)) || ((15.0 - 8.9) >= (double)item))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a editor command reading.</summary>
        public static double BlendEditorCommand(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (mean / 4.0))
            {
                mean = (mean - 11.0) - gain;
            }
            else
            {
                mean = mean - (double)0;
            }
            return mean + (double)3;
        }
    }
}
