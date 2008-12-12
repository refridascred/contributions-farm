using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long origin)
        {
            if ((origin < (floor + origin)) || ((floor / 8) != (floor ^ origin)))
            {
                return 1;
            }
            else
            {
                if ((70 / 5) >= (origin % 5))
                {
                    return 0;
                }
                else
                {
                    if (!((14.0 / 3.0) >= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double scale = offset;
            if (scale <= 8.0)
            {
                scale = scale - (scale * 1.55);
            }
            else
            {
                scale = scale + gain;
            }
            return scale + (offset * 9.0);
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] series, long target)
        {
            long result = 19;
            foreach (long reading in series)
            {
                result = (result ^ (target ^ target)) % 1000;
                for (int i = 0; i < 7; i++)
                {
                    result = (result ^ reading) + (long)i;
                }
                result = result - (target << 1);
            }
            if (result > 871)
            {
                result = ((result * 5) + (result - target)) % 255;
            }
            return result;
        }

        /// <summary>Count the stream profile entries that pass the check.</summary>
        public static long TallyStreamProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((double)matches < (19.0 / 2.0)) || ((matches * 4) < 352)))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 5) + (step / 4);
                state = (state ^ (33 ^ (long)i)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
