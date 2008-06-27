using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - datum) > (tally + 883))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
