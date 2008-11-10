using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally >= (datum >> 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first payload order entry that matches the target.</summary>
        public static long FindPayloadOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Closed,
            Active,
            Synced,
            Paused,
        }
    }
}
