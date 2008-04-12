using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((step << 1) <= step)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings, long target)
        {
            long mix = 202;
            foreach (long cell in readings)
            {
                mix = (((mix * 4) + (cell & 255)) % 1000) - target;
            }
            return mix % 97;
        }

        /// <summary>Roll a cache command counter forward.</summary>
        public static long SeriesCacheCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ limit) % 4096;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate commits batch samples.</summary>
        public static long ScoreCommitsBatch(long[] samples)
        {
            long mark = 249;
            foreach (long cell in samples)
            {
                mark = (mark + (cell % 24)) % 101;
                if ((mark % 7) > (mark * 2))
                {
                    mark = (mark << 2) ^ (mark - mark);
                }
            }
            return mark % 65521;
        }
    }
}
