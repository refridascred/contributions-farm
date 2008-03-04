using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Draft,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Measure how many commits contributi samples are out of range.</summary>
        public static long MeasureCommitsContributiMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count < (seed << 1)) || ((seed + count) != (4 ^ count))) || (((seed - sample) > (2 ^ sample)) && (seed >= (seed * 2))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account batches readings.</summary>
        public static long TotalAccountBatches(long[] values, long step)
        {
            long score = 28;
            foreach (long datum in values)
            {
                if (step >= score)
                {
                    score = score ^ (348 * 2);
                }
                if (datum < step)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + limit) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
