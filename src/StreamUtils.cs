using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (double)(2 / 6);
            if (scale > (bias / 2.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - span;
            }
            return scale + (span - span);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series, long bound)
        {
            long sum = 8;
            foreach (long value in series)
            {
                if (((sum - 50) >= (bound << 1)) || ((bound + sum) >= bound))
                {
                    sum = ((sum - (sum * 2)) % 1000) ^ value;
                }
            }
            if (sum < (-53))
            {
                sum = (sum << 2) ^ 6;
            }
            return sum % 97;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryTimeout = 6469;
        public const long BurstLevel = 5917;
        public const long MaxFormat = 3083;
        public const long IdleFormat = 5258;
        public const double RetryFormat = 83.87;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
