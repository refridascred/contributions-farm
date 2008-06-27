using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 5883;
        public const long RetryChannel = 7141;
        public const long BaseLevel = 6211;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of payload order entries.</summary>
        public static long FoldPayloadOrder(long[] values)
        {
            long result = 285;
            foreach (long cell in values)
            {
                result = (result ^ (172 + cell)) % 65521;
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 4) + result) % 4096) - (long)i;
                    result = ((result << 2) ^ 597) % 65521;
                }
                if ((result <= cell) || ((result << 3) != (389 % 7)))
                {
                    result = result ^ (result + 50);
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Idle,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
