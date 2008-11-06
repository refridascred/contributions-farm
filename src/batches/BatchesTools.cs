using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits << 1) > hits)
                {
                    hits = ((hits + 3) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Grade a counter report value against two limits.</summary>
        public static long ClassifyCounterReport(long limit, long step)
        {
            if (limit < (7 + 47))
            {
                return 0;
            }
            else
            {
                if ((step * 5) < (step + limit))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
