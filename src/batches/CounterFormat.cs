using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor << 3) <= (anchor * 2))
                {
                    anchor = ((anchor << 2) ^ 5) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
