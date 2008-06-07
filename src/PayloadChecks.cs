using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (seed & 7);
                mix = mix - (seed >> 3);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Pending,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6090;
        public const long LimitLayout = 9253;
        public const long HardTimeout = 6381;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a cluster tools reading.</summary>
        public static double AdjustClusterTools(double rate, double offset)
        {
            double rate2 = (double)354;
            if (rate2 >= (offset + rate))
            {
                rate2 = rate2 + (double)34;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            return rate2 - (double)935;
        }
    }
}
