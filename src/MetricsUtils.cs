using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((8.0 - 5.88) != (double)limit)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Ready,
            Draft,
            Done,
            Active,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long offset)
        {
            if (((5 + 19) >= (offset + 5)) && ((1.0 * 5.4) > (double)offset))
            {
                return 3;
            }
            else
            {
                if ((bound * 2) >= (bound >> 5))
                {
                    return 0;
                }
                else
                {
                    if (((bound + 177) <= ((-66) >> 4)) || ((bound % 7) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 1) >= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long acc = 73;
            foreach (long reading in levels)
            {
                if (reading >= (reading - acc))
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc > 4)
            {
                acc = (acc + (acc + acc)) % 101;
            }
            return acc % 4096;
        }
    }
}
