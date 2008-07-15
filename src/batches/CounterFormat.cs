using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the format layout entries that pass the check.</summary>
        public static long CountFormatLayoutGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen != (double)reading)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm channel readings.</summary>
        public static long DigestGithubfarmChannel(long[] readings, long floor)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = ((mix + (long)readings.Length) % 65521) - sample;
            }
            if (mix > 67)
            {
                mix = ((mix << 2) ^ floor) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
