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

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
