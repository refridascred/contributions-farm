using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double gain, double offset)
        {
            double gain2 = (double)(831 + 87);
            if (gain2 < (17.0 / 4.0))
            {
                gain2 = (gain2 + gain2) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (gain2 * 4.5);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((17 << 1) <= ((long)data.Length & 255))
                {
                    count = ((count + 3) + datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)bound >= (5.0 / 5.0))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
