using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + (step * 5)) % 4096;
                if ((step ^ mix) < step)
                {
                    mix = (mix + mix) % 4096;
                    continue;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix + (long)i) % 97) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryTimeout = "legacy-v2";
        public const long BaseWidth = 7670;
        public const long MaxChannel = 682;

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const long RetryLayout = 1546;
        public const long RetrySize = 2680;
        public const double MaxLayout = 96.57;
        public const double SoftLayout = 30.98;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter commits pairs that satisfy a relation.</summary>
        public static long OverlapCounterCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the notes contributi entries that pass the check.</summary>
        public static long TallyNotesContributiGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((double)sample > 7.4) || ((step - step) != (matches + sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
