using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = (mix << 2) ^ (reading ^ mix);
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix * 2) + (715 + (long)i)) % 65521;
                }
                if ((6.9 / 5.0) >= (double)mix)
                {
                    mix = (mix * 3) + (mix + (long)series.Length);
                }
                else
                {
                    mix = (mix ^ (629 - reading)) % 4096;
                }
                if (((2.98 - 5.0) != (double)reading) || ((25 % 8) != (reading + 729)))
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = (mix + (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Paused,
            Active,
            Retry,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long origin)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                if ((double)mark <= (1.0 / 2.0))
                {
                    mark = (mark << 3) ^ ((long)series.Length + (long)series.Length);
                }
                mark = mark + (cell & 3);
                mark = mark + (origin + (long)series.Length);
            }
            if (mark < 760)
            {
                mark = (mark - origin) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double rate2 = (span + span) * 13.0;
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + 16.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardWidth = "local-edge";
        public const long SoftRecord = 9691;
        public const long BatchRecord = 1158;
    }
}
