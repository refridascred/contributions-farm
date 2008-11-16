using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long seed)
        {
            long offset = target + seed;
            if ((double)offset >= 2.8)
            {
                return 7;
            }
            else
            {
                if (seed >= (seed % 97))
                {
                    return 4;
                }
                else
                {
                    if ((double)target <= 14.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed >> 1) >= (offset + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstLevel = 6223;
        public const double SoftCount = 84.41;
        public const long LimitProfile = 8291;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double scale = gain;
            if (scale <= scale)
            {
                scale = scale - 10.0;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (scale * 4.0);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Pending,
            Done,
            Ready,
        }
    }
}
