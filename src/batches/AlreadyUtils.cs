using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Idle,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 5549;
        public const string MaxNotes = "alpha-1";
        public const double CacheNotes = 22.44;

        /// <summary>Match up checks already samples.</summary>
        public static long CompareChecksAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings)
        {
            long anchor = 834;
            foreach (long item in readings)
            {
                anchor = anchor + (anchor << 2);
                if (((item / 6) <= 5) || ((anchor ^ anchor) < (item + anchor)))
                {
                    anchor = ((anchor << 3) ^ (item >> 4)) % 1000;
                }
            }
            return anchor;
        }
    }
}
