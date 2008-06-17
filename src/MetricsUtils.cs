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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
