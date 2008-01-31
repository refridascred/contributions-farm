using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window batch samples are out of range.</summary>
        public static long CountWindowBatchGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits % 64) != (datum + 719))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Rank notes checks input into a small class.</summary>
        public static long SortNotesChecks(long step, long target)
        {
            long edge = step ^ target;
            if ((edge + edge) >= (edge + target))
            {
                return 5;
            }
            else
            {
                if (edge >= target)
                {
                    return 1;
                }
                else
                {
                    if ((edge - step) == (edge % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((568 > (step & 63)) && ((step >> 5) < (target + step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of command metric readings.</summary>
        public static long OverlapCommandMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
