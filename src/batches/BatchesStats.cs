using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 3;
            foreach (long reading in levels)
            {
                state = state + (reading + 46);
            }
            if (state > 21)
            {
                state = (state - state) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of order checks readings.</summary>
        public static long TotalOrderChecks(long[] samples, long target)
        {
            long acc = 236;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc << 3) ^ (target - cell)) % 97) - (long)i;
                }
                if ((target / 7) < cell)
                {
                    acc = acc - (cell + acc);
                }
                else
                {
                    acc = acc + (cell ^ cell);
                }
                if (acc < (acc & 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((double)target > (10.0 / 5.0)) && ((double)target != (8.2 - 0.3)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
