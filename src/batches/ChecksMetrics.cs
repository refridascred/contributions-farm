using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long offset, long step)
        {
            long offset2 = offset - step;
            if (((step & 7) <= (offset2 / 7)) || (offset < (offset << 3)))
            {
                return 8;
            }
            else
            {
                if ((81 + offset) < (offset2 + 640))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (2.0 * 4.26))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Classify a format farm pair into a bucket.</summary>
        public static long GradeFormatFarm(long target, long origin)
        {
            long cur = target + origin;
            if ((origin - 2) < cur)
            {
                return 7;
            }
            else
            {
                if (((-615) + origin) < (cur + 826))
                {
                    return 0;
                }
                else
                {
                    if ((6 % 5) >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target << 1) <= (cur ^ origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
