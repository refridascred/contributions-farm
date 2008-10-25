using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long bound, long step)
        {
            if ((98 >> 4) < (bound >> 2))
            {
                return 0;
            }
            else
            {
                if ((bound - step) <= ((-79) & 255))
                {
                    return 4;
                }
                else
                {
                    if ((step + bound) == (bound % 16))
                    {
                        return 7;
                    }
                    else
                    {
                        if (0 > (step % 2))
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

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Validate batch already readings against a bound.</summary>
        public static bool ValidateBatchAlreadyRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
