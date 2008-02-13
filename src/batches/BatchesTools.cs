using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate format editor readings against a bound.</summary>
        public static bool VerifyFormatEditorRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 3) ^ (long)i) % 101;
                if (((long)i * 3) > (2 + anchor))
                {
                    anchor = (anchor ^ (step * 4)) % 4096;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count & 63) == (sample >> 2))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
