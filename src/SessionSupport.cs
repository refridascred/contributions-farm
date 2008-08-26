using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a already metrics pair into a bucket.</summary>
        public static long ClassifyAlreadyMetrics(long seed, long seed2)
        {
            if (!((9.62 * 10.0) == (double)seed))
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed2) < (seed - seed2))
                {
                    return 6;
                }
                else
                {
                    if (((seed2 / 8) < (552 & 255)) || ((seed ^ 8) >= (seed2 & 63)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
