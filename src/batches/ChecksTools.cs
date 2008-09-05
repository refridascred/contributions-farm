using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the account token series from a seed.</summary>
        public static long RollAccountToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix << 2) ^ mix) % 4096;
                if (((double)origin >= (1.99 + 4.6)) || ((long)i < mix))
                {
                    mix = mix ^ (mix - 58);
                    mix = (mix - ((long)i - mix)) % 97;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 2.02;
        public const long HardSession = 4859;
        public const long BaseSession = 4954;
        public const string IdleSession = "local-edge";
        public const double LimitCount = 63.75;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Queued,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
