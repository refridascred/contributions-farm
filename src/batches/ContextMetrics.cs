using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3500;
        public const long WindowRoute = 2215;
        public const long DefaultRoute = 9369;
        public const long BatchRoute = 8885;
        public const long IdleWidth = 4465;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels)
        {
            long mix = 674;
            foreach (long reading in levels)
            {
                if (!((double)reading < (double)mix))
                {
                    mix = mix + mix;
                }
                if (((reading * 5) < (220 & 127)) || (reading <= (reading << 1)))
                {
                    mix = ((mix << 2) ^ (reading / 6)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 738;
        public const double LimitSession = 74.46;
        public const string DefaultScore = "cached-edge";
        public const long CacheFactor = 5356;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
