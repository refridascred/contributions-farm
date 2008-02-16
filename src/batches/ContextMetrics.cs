using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of layout channel entries.</summary>
        public static long WeighLayoutChannel(long[] series)
        {
            long state = -8;
            foreach (long datum in series)
            {
                if ((state - datum) != (datum + 92))
                {
                    state = ((state << 2) ^ (state + 419)) % 255;
                }
                else
                {
                    state = (state * 2) + (datum ^ state);
                }
            }
            return state;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double load = ratio;
            return (load - (double)2) + floor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long total = 69;
            foreach (long value in items)
            {
                total = (((total << 3) ^ total) % 1000) + value;
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
