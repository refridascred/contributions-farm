using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first editor window entry that matches the target.</summary>
        public static long FindEditorWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already context value from a seed.</summary>
        public static long IterateAlreadyContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                if (mix <= ((long)i / 8))
                {
                    mix = mix + 1;
                    mix = mix + (mix * 5);
                }
                if (4 < mix)
                {
                    mix = (mix + (45 % 64)) % 97;
                }
                else
                {
                    mix = mix - (long)i;
                    mix = (mix - mix) % 101;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long TallyProfileLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches % 16) > (cell - matches)) && (matches > (60 ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Stale,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 8925;
        public const long MinEntry = 5232;
        public const long DefaultWidth = 4920;
        public const long BurstRatio = 4659;
        public const double BaseEntry = 37.81;

        /// <summary>Locate a schema support reading by value.</summary>
        public static long SeekSchemaSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
