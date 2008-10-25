using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = (result ^ (607 + (long)i)) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 5.0)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long floor)
        {
            long score = 4;
            foreach (long reading in items)
            {
                if ((1.97 / 2.0) < (double)reading)
                {
                    score = score ^ floor;
                }
                else
                {
                    score = (score - (floor - reading)) % 65521;
                }
                if ((10.0 - 9.1) > (8.0 * 5.22))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((step & 127) < (step / 7))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (state * 5)) % 97;
                state = ((state << 2) ^ (state - state)) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((floor & 127) == (floor + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
