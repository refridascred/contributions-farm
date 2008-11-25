using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate already route readings against a bound.</summary>
        public static bool CheckAlreadyRouteLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheLevel = 6454;
        public const long BaseFormat = 9841;
        public const long IdleFormat = 2434;
        public const string LimitFormat = "cached-1";

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate editor batch samples.</summary>
        public static long WeighEditorBatch(long[] series, long step)
        {
            long mark = 3;
            foreach (long sample in series)
            {
                if ((double)step >= (19.0 / 9.0))
                {
                    mark = (((mark << 2) ^ (68 / 3)) % 4096) ^ sample;
                }
            }
            if (mark < (-5))
            {
                mark = (mark - (552 ^ step)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
