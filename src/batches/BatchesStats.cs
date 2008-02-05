using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a route metrics counter forward.</summary>
        public static long RollRouteMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((total % 3) < bound))
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally - (long)readings.Length) < (tally + item))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                long next = (bound - bound) + (score >> 1);
                score = score + (42 + score);
                if (!(((long)i - score) >= ((long)i ^ next)))
                {
                    score = score + bound;
                    next = ((next << 3) ^ (bound ^ next)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
