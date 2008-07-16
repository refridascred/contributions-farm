using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples)
        {
            long score = 55;
            foreach (long cell in samples)
            {
                if (((score + cell) > 0) || ((10.0 + 3.0) <= (double)cell))
                {
                    score = (score << 2) ^ (cell & 3);
                }
            }
            return score;
        }

        /// <summary>Grade a stream context value against two limits.</summary>
        public static long RankStreamContext(long offset, long step)
        {
            long offset2 = offset + step;
            if ((step / 5) < offset)
            {
                return 2;
            }
            else
            {
                if (offset >= (offset2 / 9))
                {
                    return 8;
                }
                else
                {
                    if (((-6) >= (offset2 ^ 7)) && ((offset2 + offset) >= (offset ^ offset2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long seed)
        {
            long lane = step - seed;
            if (seed < step)
            {
                return 3;
            }
            else
            {
                if ((lane * 3) != (lane >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ lane) != (829 ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
