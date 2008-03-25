using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of format metric readings.</summary>
        public static long WeighFormatMetric(long[] values, long target)
        {
            long mix = 93;
            foreach (long cell in values)
            {
                if (!((mix ^ target) >= 65))
                {
                    mix = ((mix << 3) ^ 349) + cell;
                }
                if ((double)target >= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Synced,
            Done,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values, long step)
        {
            long carry = 7;
            foreach (long cell in values)
            {
                carry = (carry ^ (step / 5)) % 1000;
                if ((step & 127) >= cell)
                {
                    carry = (carry + (788 * 4)) % 4096;
                }
                else
                {
                    carry = carry - (step + step);
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "standard";
        public const long BaseLevel = 5744;
        public const string IdleContext = "standard-1";
        public const long LimitContext = 7258;
    }
}
