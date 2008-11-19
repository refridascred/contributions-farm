using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a record layout counter forward.</summary>
        public static long StepRecordLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ bound) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count schema cluster pairs that satisfy a relation.</summary>
        public static long OverlapSchemaClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
