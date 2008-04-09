using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9621;
        public const double BaseLayout = 93.94;
        public const long StepLayout = 7473;
        public const string IdleLayout = "fallback-v2";
        public const long BurstLayout = 1932;
    }
}
