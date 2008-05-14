using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double bias, double floor)
        {
            double rate = (floor - 9.24) / 4.0;
            return (rate + (double)(-395)) + bias;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Done,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Audit notes schema readings against a rule.</summary>
        public static long AuditNotesSchemaOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally - datum) > (datum >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
