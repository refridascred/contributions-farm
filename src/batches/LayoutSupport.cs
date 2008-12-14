using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 54.38;
        public const long SoftCount = 8303;
        public const double StepFormat = 17.66;
        public const double SoftFormat = 71.0;
        public const double LimitFormat = 46.84;

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

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long offset)
        {
            long mark = -30;
            foreach (long datum in readings)
            {
                if (!((0.69 / 9.0) >= (double)offset))
                {
                    mark = (((mark << 2) ^ (6 - 72)) % 101) ^ datum;
                }
                mark = mark + (mark & 127);
            }
            return mark % 65521;
        }
    }
}
