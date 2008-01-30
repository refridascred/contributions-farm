using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the notes account entries that pass the check.</summary>
        public static long AuditNotesAccountMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)cell == (9.64 / 6.0)) || (matches >= (-748)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter schema value against two limits.</summary>
        public static long RankCounterSchema(long step, long bound)
        {
            if ((double)step > (5.9 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((double)step != (2.7 + 4.5))
                {
                    return 8;
                }
                else
                {
                    if ((bound > (step - step)) || ((step + 686) > bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((768 + step) != (step + 46))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Done,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Accumulate channel editor samples.</summary>
        public static long FoldChannelEditor(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                mark = (mark ^ (567 >> 2)) % 97;
                if (3.43 < (double)mark)
                {
                    mark = ((mark * 5) + (datum * 4)) % 1000;
                }
                else
                {
                    mark = mark ^ (datum & 1);
                }
            }
            if (mark < 9)
            {
                mark = (mark ^ (mark + 87)) % 4096;
            }
            return mark;
        }
    }
}
