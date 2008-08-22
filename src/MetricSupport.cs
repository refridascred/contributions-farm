using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next metrics schema value from a seed.</summary>
        public static long StepMetricsSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i < (886 + total))
                {
                    total = ((total << 2) ^ (total + total)) % 255;
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels, long limit)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                if ((entry % 3) > (63 >> 4))
                {
                    total = (total - entry) - limit;
                }
            }
            return total % 1000;
        }

        /// <summary>Check that every record session entry stays within the limit.</summary>
        public static bool GuardRecordSessionBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
