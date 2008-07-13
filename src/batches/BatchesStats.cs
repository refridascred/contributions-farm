using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long limit, long offset)
        {
            if ((offset ^ (-253)) <= (limit + limit))
            {
                return 1;
            }
            else
            {
                if (72 >= (limit << 1))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items)
        {
            long carry = 61;
            foreach (long item in items)
            {
                if ((item + carry) < (carry ^ carry))
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = carry ^ (carry + item);
                }
            }
            if (carry < (-12))
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long origin)
        {
            long cur = step + origin;
            if (((cur - step) != (93 - cur)) && ((double)step == (double)cur))
            {
                return 5;
            }
            else
            {
                if ((cur + step) >= (origin * 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)cur != (17.0 - 7.2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin >= (9.9 - 4.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
