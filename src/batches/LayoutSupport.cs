using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Count token checks pairs that satisfy a relation.</summary>
        public static long PairTokenChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((datum + matches) > datum) || ((seed - datum) < seed))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((-404) - anchor) <= (long)i)
                {
                    anchor = anchor + (anchor + anchor);
                    anchor = ((anchor << 3) ^ (limit + (long)i)) % 101;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
