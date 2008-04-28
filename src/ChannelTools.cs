using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next payload command value.</summary>
        public static double AdjustPayloadCommand(double scale, double span)
        {
            double drift = 5.0 / 9.0;
            if (drift <= (drift - span))
            {
                drift = drift + scale;
            }
            return drift - (drift + span);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes checks entry stays within the limit.</summary>
        public static bool GuardNotesChecksLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
