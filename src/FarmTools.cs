using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 1) <= entry)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items, long origin)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                mix = ((((mix << 3) ^ mix) % 97) + cell) + origin;
            }
            return mix;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix << 3) ^ 877;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
