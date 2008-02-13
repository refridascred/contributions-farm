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

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long bound)
        {
            long offset = step + bound;
            if ((double)offset <= (6.09 + 1.08))
            {
                return 3;
            }
            else
            {
                if (((1 % 8) < (31 + offset)) && ((step << 1) >= offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
