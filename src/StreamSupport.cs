using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + count) > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a counter graph pair into a bucket.</summary>
        public static long RankCounterGraph(long step, long floor)
        {
            long bound = step - floor;
            if ((double)step >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound >= (bound * 3)) || (bound < (bound + step)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
