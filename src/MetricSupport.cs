using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (origin * 4)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (mix - (mix + mix)) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings, long target)
        {
            long result = 8;
            foreach (long sample in readings)
            {
                result = (result << 3) ^ sample;
            }
            if (result > 64)
            {
                result = result - (result - target);
            }
            return result;
        }

        /// <summary>Audit farm schema readings against a rule.</summary>
        public static long MeasureFarmSchemaOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry >> 2) <= 22)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
