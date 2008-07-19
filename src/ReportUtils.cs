using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long step)
        {
            long mark = 2;
            foreach (long entry in items)
            {
                mark = mark ^ 3;
                if ((double)entry < 3.3)
                {
                    mark = ((mark * 4) + mark) % 101;
                }
                else
                {
                    mark = ((mark * 5) + (step << 1)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long origin)
        {
            long bound = limit ^ origin;
            if ((double)bound > (0.5 - 4.0))
            {
                return 0;
            }
            else
            {
                if ((4 + bound) >= (bound & 15))
                {
                    return 2;
                }
                else
                {
                    if (!((bound - 60) > bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double load = span / 3.0;
            if (load < span)
            {
                load = (load - load) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load * 8.9)) + (double)(long)i;
            }
            return load + (load - load);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items)
        {
            long result = -462;
            foreach (long value in items)
            {
                if ((value << 1) >= value)
                {
                    result = (result ^ value) % 255;
                }
            }
            if (result < 594)
            {
                result = result + (result & 3);
            }
            return result;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Retry,
            Synced,
        }
    }
}
