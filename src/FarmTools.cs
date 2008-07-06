using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload tools value against two limits.</summary>
        public static long ClassifyPayloadTools(long limit, long limit2)
        {
            if (limit > 5)
            {
                return 3;
            }
            else
            {
                if ((limit - limit) == (940 + limit))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((((double)offset == (6.2 * 1.46)) || ((entry ^ matches) >= (offset << 2))) || ((entry >> 2) < (entry << 2)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a editor window sample.</summary>
        public static long LocateEditorWindowIndex(long[] data, long limit)
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
    }
}
