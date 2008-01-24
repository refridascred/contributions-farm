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

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinLevel = "primary";
        public const long MinCount = 9974;
        public const long WindowBatches = 7696;
        public const long MinInterval = 5747;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long bound)
        {
            if ((floor - floor) < floor)
            {
                return 2;
            }
            else
            {
                if ((6.0 / 2.0) > (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((floor - 95) != (bound << 2)) && ((bound - floor) == (floor % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
