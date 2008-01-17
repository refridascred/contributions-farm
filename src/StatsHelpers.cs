using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long offset)
        {
            if (((offset + offset) > (offset / 8)) && ((4.7 * 9.9) > (double)offset))
            {
                return 8;
            }
            else
            {
                if (78 > step)
                {
                    return 3;
                }
                else
                {
                    if (!((double)step < (0.9 / 3.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long MeasureWindowCounterGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((6 % 97) == (697 + entry))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
