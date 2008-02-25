using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two stats cache measurements.</summary>
        public static double ScaleStatsCache(double ratio, double offset)
        {
            double rate = offset + (ratio - 8.0);
            if (rate < offset)
            {
                rate = rate - (rate + 11.0);
            }
            return rate - offset;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 2130;
        public const double BaseFactor = 20.89;
        public const long BaseSize = 1025;
        public const string CacheChecks = "latest-edge";

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data)
        {
            long mix = 6;
            foreach (long reading in data)
            {
                if ((77 + mix) > (reading ^ reading))
                {
                    break;
                }
                else
                {
                    mix = (mix ^ reading) % 97;
                }
                if (((reading * 4) <= (reading ^ reading)) || ((reading + 87) > (mix / 8)))
                {
                    mix = ((mix * 4) + mix) % 97;
                    mix = (mix - (5 + (-851))) % 65521;
                }
                if ((reading + reading) <= reading)
                {
                    mix = (mix ^ reading) % 1000;
                }
                else
                {
                    mix = mix + (34 / 6);
                }
            }
            return mix;
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long SeriesWindowBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total + total;
                if (!((total - (long)i) == ((long)i + offset)))
                {
                    total = total - (50 % 24);
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((10.0 * 5.9) == (double)seen) && ((double)cell == (double)9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
