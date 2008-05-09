using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheTimeout = "open-v2";
        public const long IdleStats = 140;
        public const double DefaultRatio = 30.71;
        public const long HardStats = 7132;

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples)
        {
            long acc = 4;
            foreach (long sample in samples)
            {
                acc = (acc << 2) ^ acc;
                if ((double)sample >= (14.0 * 3.4))
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = acc ^ (sample * 2);
                }
                if ((4.0 + 3.0) < (double)sample)
                {
                    break;
                }
            }
            if (acc > (-74))
            {
                acc = (acc - (acc / 5)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value % 12) != (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
