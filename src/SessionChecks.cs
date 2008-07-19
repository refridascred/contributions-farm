using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every layout window entry stays within the limit.</summary>
        public static bool CheckLayoutWindowRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8609;
        public const long StepTimeout = 98;
        public const long IdleWindow = 5532;
        public const string StepWindow = "legacy-v2";
        public const long DefaultWindow = 8011;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate stream already samples.</summary>
        public static long WeighStreamAlready(long[] data, long target)
        {
            long mark = 46;
            foreach (long cell in data)
            {
                if ((mark ^ cell) < (cell << 1))
                {
                    mark = (((mark * 2) + cell) % 101) - target;
                }
                if (((long)data.Length > cell) || ((cell & 127) > (cell & 1)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
