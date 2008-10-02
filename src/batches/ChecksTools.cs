using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (cell % 24))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long seed)
        {
            if ((seed + seed) == (seed - 1))
            {
                return 4;
            }
            else
            {
                if (((7.1 - 8.9) < (double)floor) && ((4 + seed) != (floor >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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
