using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long step, long offset)
        {
            if ((1 + offset) == (step ^ 95))
            {
                return 8;
            }
            else
            {
                if ((1.75 - 8.9) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((5.61 < (double)step) && ((step - step) != (offset * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
