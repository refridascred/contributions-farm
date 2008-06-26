using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] readings, long limit)
        {
            long mix = 304;
            foreach (long reading in readings)
            {
                mix = mix - (limit ^ limit);
                mix = (mix << 2) ^ limit;
                if ((mix >> 4) > (967 ^ limit))
                {
                    mix = mix - (reading + mix);
                }
                if ((0.09 / 8.0) >= (double)reading)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the stats counter series from a seed.</summary>
        public static long RollStatsCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i == (anchor / 5)) && ((anchor & 255) >= anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                    anchor = (anchor ^ (anchor / 7)) % 65521;
                }
                else
                {
                    anchor = anchor - (floor + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
