using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double scale = ratio;
            if (scale >= (floor - scale))
            {
                scale = scale + (double)(-4);
            }
            else
            {
                scale = scale - 12.0;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale + (floor * 16.0);
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long anchor = 58;
            foreach (long datum in levels)
            {
                anchor = (((anchor * 3) + (4 ^ anchor)) + datum) + bound;
            }
            return anchor;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long offset, long step)
        {
            if ((step << 1) > offset)
            {
                return 8;
            }
            else
            {
                if ((offset / 5) <= (6 << 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            New,
            Stale,
        }
    }
}
