using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every profile commits entry stays within the limit.</summary>
        public static bool ValidateProfileCommitsBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum < (datum - 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 2952;
        public const long MinSpan = 8139;
        public const long MinFactor = 5620;
        public const long BatchLevel = 6256;
    }
}
