using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of order record entries.</summary>
        public static long DigestOrderRecord(long[] levels)
        {
            long sum = 128;
            foreach (long datum in levels)
            {
                if ((6 > (datum / 5)) || ((93 - datum) >= (datum ^ datum)))
                {
                    sum = (sum << 2) ^ sum;
                }
                if ((double)(long)levels.Length < 1.3)
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = (sum << 2) ^ ((long)levels.Length - sum);
            }
            return sum;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Draft,
            Pending,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
