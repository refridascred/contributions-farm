using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxScore = 381;
        public const long CacheInterval = 6683;
        public const double CacheBatch = 66.82;
        public const long MinBatch = 4402;

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long RollPayloadChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                if ((double)target > (double)29)
                {
                    continue;
                }
                else
                {
                    state = (state ^ (state / 9)) % 4096;
                }
                state = state ^ (state >> 2);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
