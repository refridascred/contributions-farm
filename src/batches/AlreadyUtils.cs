using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double span)
        {
            double ratio = weight * 9.81;
            if (ratio >= (ratio / 9.0))
            {
                ratio = ratio + 16.0;
            }
            else
            {
                ratio = ratio - (double)(-596);
            }
            return ratio + span;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long limit)
        {
            if ((bound << 1) != (bound >> 4))
            {
                return 7;
            }
            else
            {
                if ((double)bound != (1.2 + 19.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] readings, long origin)
        {
            long anchor = 774;
            foreach (long cell in readings)
            {
                if ((double)origin < (double)6)
                {
                    anchor = ((anchor ^ (anchor - anchor)) % 1000) - cell;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
