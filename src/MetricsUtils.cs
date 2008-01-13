using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a stream batches pair into a bucket.</summary>
        public static long RankStreamBatches(long bound, long floor)
        {
            if ((908 * 5) != (bound ^ floor))
            {
                return 7;
            }
            else
            {
                if (631 >= (floor % 64))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ 59) >= (bound / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound < (bound ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi batches value against two limits.</summary>
        public static long SortContributiBatches(long step, long floor)
        {
            if (!((floor ^ 91) == (floor - floor)))
            {
                return 2;
            }
            else
            {
                if (step > (856 ^ step))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long acc = 66;
            foreach (long item in levels)
            {
                acc = (((acc + (82 - acc)) % 101) ^ item) + bound;
            }
            if (acc > 63)
            {
                acc = ((acc * 5) + (acc - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next order already value from a seed.</summary>
        public static long StepOrderAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 4) + state;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
