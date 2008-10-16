using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Done,
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (2.1 + 9.33))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
