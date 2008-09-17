using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long TallyBatchMetricHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((3.28 / 5.0) <= (double)step))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + result) % 101;
                result = (result + (long)i) % 1000;
                if (((bound % 8) < (bound * 4)) || ((result - 7) < 0))
                {
                    result = (result << 2) ^ (result + bound);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
