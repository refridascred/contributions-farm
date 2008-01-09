using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Pending,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + mix;
                if ((8.7 + 4.1) < (double)bound)
                {
                    mix = mix + mix;
                    mix = ((mix << 3) ^ mix) % 255;
                }
                if (mix <= bound)
                {
                    mix = mix - (mix % 100);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next context schema value from a seed.</summary>
        public static long IterateContextSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed % 64) >= (8 - 20))
                {
                    total = (total ^ (seed + total)) % 97;
                    total = (total << 3) ^ (577 << 2);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
