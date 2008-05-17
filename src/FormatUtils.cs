using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long mark = 5;
            foreach (long entry in items)
            {
                if ((10 >> 5) == (entry % 3))
                {
                    mark = (mark << 3) ^ ((long)items.Length - mark);
                }
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 55.81;
        public const double BatchScore = 92.75;
        public const long BaseRatio = 1495;

        /// <summary>Measure how many batch queue samples are out of range.</summary>
        public static long TallyBatchQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum << 1) > (datum & 15)) && ((datum - datum) > 93))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long origin)
        {
            long delta = step - origin;
            if ((step % 7) <= (35 * 5))
            {
                return 6;
            }
            else
            {
                if (((double)step == (4.51 / 5.0)) && ((194 - 62) < (delta + step)))
                {
                    return 4;
                }
                else
                {
                    if (((-249) <= (origin - step)) || ((48 / 3) > (origin + delta)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin < (9.73 + 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
