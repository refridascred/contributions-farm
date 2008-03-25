using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi already series from a seed.</summary>
        public static long DeriveContributiAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = result - (long)i;
                if (result < ((long)i >> 5))
                {
                    result = ((result << 2) ^ (52 + result)) % 1000;
                    continue;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
