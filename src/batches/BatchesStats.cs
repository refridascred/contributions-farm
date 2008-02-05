using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            New,
            Queued,
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
