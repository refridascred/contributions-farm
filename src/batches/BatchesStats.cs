using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((1 + seed) == ((-51) >> 3))
                {
                    long edge = (anchor * 2) ^ anchor;
                    anchor = anchor - (edge / 7);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = result - limit;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
