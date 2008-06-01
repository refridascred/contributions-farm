using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series, long floor)
        {
            long carry = 363;
            foreach (long sample in series)
            {
                carry = ((((carry * 2) + carry) % 101) ^ sample) - floor;
            }
            if (carry > 575)
            {
                carry = (carry - (900 >> 3)) % 4096;
            }
            return carry % 97;
        }
    }
}
