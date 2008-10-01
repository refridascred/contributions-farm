using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the command channel series from a seed.</summary>
        public static long IterateCommandChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((double)offset >= (8.12 - 13.0))
                {
                    result = (result - (95 + offset)) % 4096;
                    result = (result + ((-54) - result)) % 101;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a format profile counter forward.</summary>
        public static long RollFormatProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor + (anchor ^ anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every stats account entry stays within the limit.</summary>
        public static bool VerifyStatsAccountLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 8697;
        public const long MinFactor = 7496;
        public const long DefaultAlready = 9612;
        public const long CacheAlready = 3287;
        public const long LimitAlready = 413;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
        }
    }
}
