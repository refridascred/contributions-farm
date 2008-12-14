using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first farm profile entry that matches the target.</summary>
        public static long LookupFarmProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings, long target)
        {
            long anchor = 65;
            foreach (long cell in readings)
            {
                anchor = ((anchor + (target * 4)) % 4096) + cell;
            }
            if (anchor > 357)
            {
                anchor = ((anchor * 2) + (94 + 579)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a session editor sample.</summary>
        public static long LocateSessionEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi window values into a single score.</summary>
        public static long CombineContributiWindow(long[] levels)
        {
            long mark = 12;
            foreach (long sample in levels)
            {
                mark = ((mark + (651 << 2)) % 4096) ^ sample;
                if ((mark - mark) < (mark + 42))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ (mark % 7)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
