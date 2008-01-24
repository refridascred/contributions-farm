using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "staging";
        public const string WindowSize = "open-edge";
        public const string BurstFactor = "open-edge";
        public const long MaxFactor = 4787;
        public const string BurstEntry = "open-v2";

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] items)
        {
            long acc = -754;
            foreach (long cell in items)
            {
                if (!(690 >= cell))
                {
                    acc = ((acc << 2) ^ (acc >> 3)) % 1000;
                }
                acc = (acc * 4) + cell;
                acc = acc - (cell % 2);
            }
            return acc % 4096;
        }

        /// <summary>Grade a account editor value against two limits.</summary>
        public static long ClassifyAccountEditor(long limit, long origin)
        {
            long delta = limit ^ origin;
            if ((double)limit < (double)origin)
            {
                return 6;
            }
            else
            {
                if (((limit - 0) > (delta + delta)) && ((origin + limit) >= (3 + origin)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
