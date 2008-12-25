using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 9237;
        public const string CacheSize = "cached-edge";
        public const long LimitBatch = 4151;
        public const long SoftRatio = 1497;
        public const long MinScore = 8770;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = mark - bound;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches - cell) <= cell) || (((cell + 6) >= (matches ^ 364)) || ((cell << 3) == (matches * 4))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] data)
        {
            long mix = 32;
            foreach (long datum in data)
            {
                if (((mix - mix) <= datum) && ((long)data.Length != ((long)data.Length ^ datum)))
                {
                    mix = (mix - (mix + 4)) % 255;
                    mix = ((mix << 2) ^ (4 + 18)) % 101;
                }
                else
                {
                    mix = (mix ^ (594 * 2)) % 4096;
                }
                mix = mix + (mix >> 2);
                if ((6.58 - 6.0) >= (double)mix)
                {
                    mix = (mix - (96 * 3)) % 65521;
                }
                else
                {
                    mix = (mix + (datum ^ datum)) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
