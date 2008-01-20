using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "alpha";
        public const string CacheCount = "standard-v2";
        public const string StepLevel = "local-edge";

        /// <summary>Measure how many buffer command samples are out of range.</summary>
        public static long MeasureBufferCommandGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < step)
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long MeasureContributiRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally > (long)readings.Length) || (4.7 <= (18.0 - 1.0)))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}
