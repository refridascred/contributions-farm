using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long TallyFormatPayloadHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((2.0 / 9.0) <= (double)tally)
                {
                    tally = ((tally + 2) - entry) + target;
                }
            }
            return tally;
        }
    }
}
