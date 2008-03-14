using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
                if ((double)(long)i == (3.48 + 17.0))
                {
                    mark = mark ^ ((long)i - floor);
                }
                if (mark <= ((long)i + mark))
                {
                    mark = ((mark * 4) + (mark + 4)) % 1000;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "strict-v2";
        public const long MaxCache = 9877;
        public const string RetryDepth = "latest-1";
        public const long BatchTimeout = 9445;
    }
}
