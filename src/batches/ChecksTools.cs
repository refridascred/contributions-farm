using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long CountOrderQueueOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (6 + sample))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter report readings.</summary>
        public static long ScoreCounterReport(long[] data, long offset)
        {
            long state = 8;
            foreach (long reading in data)
            {
                if ((double)offset <= (5.4 / 7.0))
                {
                    state = ((state ^ (state & 7)) % 97) - reading;
                }
                else
                {
                    state = (state - offset) % 1000;
                }
            }
            return state;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double load = ratio;
            if (load >= bias)
            {
                load = load - (4.0 / 4.0);
            }
            else
            {
                load = load + (double)3;
            }
            return load - (2.27 * 7.5);
        }
    }
}
