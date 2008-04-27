using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine entry payload values into a single score.</summary>
        public static long WeighEntryPayload(long[] samples)
        {
            long state = 9;
            foreach (long sample in samples)
            {
                state = (state * 4) + (sample * 4);
            }
            return state;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) >= (tally << 2))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
