using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long MeasureFormatAlreadyGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((16.0 / 9.0) <= (double)tally)
                {
                    tally = ((tally + 3) - item) + target;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = mix + (seed << 1);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit cluster counter readings against a rule.</summary>
        public static long TallyClusterCounterMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)offset == (6.3 - 3.0))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
