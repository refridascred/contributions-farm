using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinDepth = 85.26;
        public const string DefaultInterval = "legacy-edge";
        public const long MaxAlready = 1558;
        public const long BurstWidth = 5843;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long step, long step2)
        {
            long diff = step ^ step2;
            if (!(step > diff))
            {
                return 2;
            }
            else
            {
                if ((diff / 6) == (diff << 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
