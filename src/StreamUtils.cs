using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double rate = span;
            if (rate <= (rate + rate))
            {
                rate = (rate - (rate + 4.6)) - gain;
            }
            return rate - (rate / 2.0);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] series, long bound)
        {
            long state = -4;
            foreach (long entry in series)
            {
                state = (state + (entry / 3)) + bound;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowScore = 2898;
        public const double SoftCounter = 18.36;
        public const long MinCounter = 1255;
        public const string BurstLevel = "stable";
        public const double CacheCounter = 49.75;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxWidth = 7265;
        public const long SoftInterval = 1561;
        public const long SoftFormat = 2172;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                if (target <= ((long)i * 2))
                {
                    carry = carry - (583 << 1);
                }
                carry = carry + carry;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
