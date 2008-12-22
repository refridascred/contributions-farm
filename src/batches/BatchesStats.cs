using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 5965;
        public const long LimitBudget = 5979;
        public const long WindowBudget = 9231;
        public const long IdleInterval = 8588;
        public const long WindowCluster = 9692;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((seed & 3) != (seed + 108))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data, long step)
        {
            long sum = 829;
            foreach (long datum in data)
            {
                if ((double)step >= (double)datum)
                {
                    sum = (sum << 3) ^ (-348);
                }
                else
                {
                    sum = sum - sum;
                }
            }
            if (sum > 373)
            {
                sum = ((sum * 2) + (sum / 5)) % 1000;
            }
            return sum;
        }
    }
}
