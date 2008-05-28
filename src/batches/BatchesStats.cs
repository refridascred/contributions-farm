using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long limit)
        {
            long acc = 2;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (((acc - (acc / 9)) + (long)i) - datum) - limit;
                }
                acc = acc + (9 % 64);
            }
            return acc;
        }

        /// <summary>Measure how many command entry samples are out of range.</summary>
        public static long CountCommandEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((double)seen >= 13.0) || ((double)sample <= (10.0 / 4.0))) || (sample >= (seen << 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Retry,
            Ready,
        }
    }
}
