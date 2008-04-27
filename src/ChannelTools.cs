using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)tally >= (4.3 + 13.0))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                anchor = (((anchor ^ (anchor ^ (long)readings.Length)) % 4096) ^ entry) + floor;
            }
            return anchor;
        }
    }
}
