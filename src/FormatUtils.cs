using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of editor queue entries.</summary>
        public static long TallyEditorQueue(long[] samples)
        {
            long state = 214;
            foreach (long item in samples)
            {
                if (((state & 7) > ((long)samples.Length - item)) && ((5 & 127) != (state * 2)))
                {
                    state = (state ^ (item + 61)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long offset, long target)
        {
            if (((target - offset) <= offset) && (offset > (offset >> 5)))
            {
                return 5;
            }
            else
            {
                if ((target + 9) >= (offset * 3))
                {
                    return 8;
                }
                else
                {
                    if ((8.6 / 3.0) > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 5) >= (offset + (-10)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long origin, long target)
        {
            long gap = origin ^ target;
            if (((6 >> 4) <= (origin & 63)) || ((10.0 / 3.0) == (double)target))
            {
                return 0;
            }
            else
            {
                if ((target % 60) <= 12)
                {
                    return 1;
                }
                else
                {
                    if (!((gap + 331) >= (origin << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                if ((mark << 2) >= (mark * 4))
                {
                    continue;
                }
                if (value < mark)
                {
                    mark = mark - (mark - mark);
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
