using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double scale, double offset)
        {
            double ratio = (scale + offset) * 17.0;
            if (ratio <= offset)
            {
                ratio = ratio + (double)40;
            }
            else
            {
                ratio = ratio - (0.4 + offset);
            }
            return ratio - ratio;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Limit { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)value == (7.28 / 4.0)) || (3.0 > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series, long step)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                if (((mix & 63) != (step << 2)) && (((long)series.Length - datum) <= (mix * 4)))
                {
                    mix = (mix - (mix * 4)) % 65521;
                }
            }
            if (mix < 461)
            {
                mix = mix ^ (mix - step);
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
