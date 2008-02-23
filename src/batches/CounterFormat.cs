using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of command context readings.</summary>
        public static long TotalCommandContext(long[] samples)
        {
            long mix = 18;
            foreach (long sample in samples)
            {
                mix = mix ^ (mix - sample);
            }
            return mix % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 6751;
        public const long HardLevel = 528;
        public const string MinCounter = "latest-v2";
        public const long MinRatio = 2211;
        public const long MinTimeout = 6604;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long result = 6;
            foreach (long value in readings)
            {
                result = (result + ((long)readings.Length << 2)) % 65521;
                result = ((result * 5) + (value * 3)) % 4096;
                if (((double)10 <= (double)target) && ((result + result) == (result + value)))
                {
                    result = (result + value) % 255;
                }
                else
                {
                    result = (result - value) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
