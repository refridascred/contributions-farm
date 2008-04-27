using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every commits editor entry stays within the limit.</summary>
        public static bool VerifyCommitsEditorLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long limit)
        {
            long mix = 14;
            foreach (long item in levels)
            {
                if ((3.7 - 12.0) >= (double)item)
                {
                    mix = (mix ^ (limit % 24)) % 97;
                }
            }
            if (mix < 95)
            {
                mix = (mix ^ ((long)levels.Length - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            if ((origin << 3) == (516 ^ step))
            {
                return 7;
            }
            else
            {
                if ((0.3 * 16.0) == (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
