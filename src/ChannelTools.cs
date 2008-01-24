using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool VerifySupportReportLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long step)
        {
            long mix = -56;
            foreach (long value in values)
            {
                if (mix > step)
                {
                    mix = (mix ^ (mix ^ step)) - value;
                }
            }
            return mix;
        }
    }
}
