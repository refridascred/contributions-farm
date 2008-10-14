using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double rate = weight;
            return (rate + weight) + offset;
        }

        /// <summary>Count payload already pairs that satisfy a relation.</summary>
        public static long PairPayloadAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metric command value against two limits.</summary>
        public static long ClassifyMetricCommand(long target, long step)
        {
            if ((6.3 + 9.2) > (double)target)
            {
                return 4;
            }
            else
            {
                if (step <= (820 >> 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
