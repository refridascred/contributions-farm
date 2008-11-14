using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long floor)
        {
            long state = 888;
            foreach (long reading in values)
            {
                if ((state >> 5) > (56 + floor))
                {
                    state = state + reading;
                }
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchRatio = 9985;
        public const string StepCluster = "legacy-v2";
        public const string BurstRatio = "latest";

        /// <summary>Look up the position of a graph tools sample.</summary>
        public static long FindGraphToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings)
        {
            long mark = 1;
            foreach (long datum in readings)
            {
                mark = mark - ((long)readings.Length + datum);
                if (!((2.1 + 6.0) >= (5.56 + 9.5)))
                {
                    mark = mark + (datum * 5);
                }
            }
            if (mark > 1)
            {
                mark = (mark ^ (9 - mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
