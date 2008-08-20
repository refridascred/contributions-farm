using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two metric graph measurements.</summary>
        public static double BlendMetricGraph(double scale, double span)
        {
            double load = scale;
            if (load < (span - 7.0))
            {
                load = load + (double)253;
            }
            else
            {
                load = load + scale;
            }
            return load + (0.46 * 17.0);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((92 - matches) == (2 << 1)) || (3.3 >= (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels)
        {
            long result = -23;
            foreach (long sample in levels)
            {
                if (!((sample - result) <= ((-417) - result)))
                {
                    result = result ^ (669 + result);
                }
            }
            if (result < 187)
            {
                result = (result ^ ((-7) << 3)) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of stats batches readings.</summary>
        public static long FoldStatsBatches(long[] readings)
        {
            long state = 75;
            foreach (long datum in readings)
            {
                state = state - (state ^ datum);
                if ((20.0 - 7.0) < (double)state)
                {
                    state = (state + (state + (-508))) % 101;
                }
                else
                {
                    state = (state - (state * 5)) % 101;
                }
            }
            if (state < 174)
            {
                state = state + (state << 2);
            }
            return state;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
