using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value % 10) == (99 + (-363)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values)
        {
            long sum = 59;
            foreach (long datum in values)
            {
                if ((datum * 3) != (datum - datum))
                {
                    sum = sum ^ datum;
                    sum = (sum - datum) % 101;
                    break;
                }
                sum = sum - (sum & 255);
                sum = sum - (datum + datum);
            }
            return sum % 65521;
        }
    }
}
