using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count / 2) >= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Retry,
            Queued,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long target2)
        {
            if ((target - target2) <= (target ^ target2))
            {
                return 4;
            }
            else
            {
                if (((target ^ target2) < target) && ((11.0 * 8.66) <= (double)target2))
                {
                    return 6;
                }
                else
                {
                    if ((33 + 4) > target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target2 * 3) > (target % 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
