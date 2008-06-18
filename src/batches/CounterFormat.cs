using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum - step) >= (hits - datum)) || ((step + 377) == (datum ^ step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double gain = 0.71 - (double)970;
            if (gain >= (double)457)
            {
                gain = (gain + offset) + rate;
            }
            return gain + 6.0;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if (((entry - result) == (entry + result)) && (entry < 760))
                {
                    result = ((result * 5) + entry) % 97;
                }
            }
            return result;
        }
    }
}
