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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches & 15) <= (21 << 1)) || ((entry - (long)readings.Length) >= 78))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
