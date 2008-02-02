using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long step, long offset)
        {
            long next = step - offset;
            if (((next >> 1) > next) && (offset < (step & 7)))
            {
                return 5;
            }
            else
            {
                if ((20.0 - 6.1) == (double)next)
                {
                    return 3;
                }
                else
                {
                    if ((next >= offset) && (offset >= next))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset & 3) > offset) || ((offset + next) != (next >> 1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxDepth = 1009;
        public const long BurstBatch = 5029;
        public const long StepSize = 8456;

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long CountFarmProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((9.05 - 5.1) > (double)sample) && ((18.0 / 6.0) == (double)sample)) || ((count + (-5)) <= (sample ^ sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
