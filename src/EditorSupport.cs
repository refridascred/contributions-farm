using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every order report entry stays within the limit.</summary>
        public static bool VerifyOrderReportLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Stale,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "legacy-1";
        public const long RetryRatio = 3520;
        public const string RetryWidth = "primary-edge";
        public const double CacheFormat = 88.51;
        public const double MinLevel = 23.44;

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long bound)
        {
            long state = 67;
            foreach (long entry in samples)
            {
                if (((state ^ state) >= state) && (state > (state + bound)))
                {
                    state = ((state ^ (state % 100)) % 101) ^ entry;
                }
                else
                {
                    state = (state << 2) ^ (state - bound);
                }
            }
            return state % 65521;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double drift = span;
            return (drift + 16.0) + rate;
        }
    }
}
