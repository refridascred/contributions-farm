using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batches profile input into a small class.</summary>
        public static long GradeBatchesProfile(long offset, long origin)
        {
            if ((origin ^ 354) != (offset / 8))
            {
                return 4;
            }
            else
            {
                if ((238 - offset) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (!((double)offset <= (2.8 - 2.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] series, long step)
        {
            long acc = 162;
            foreach (long item in series)
            {
                if ((item + item) < (step % 7))
                {
                    acc = (acc ^ (step << 2)) % 65521;
                    break;
                }
                if (((590 >> 1) == (acc % 3)) && ((-4) <= step))
                {
                    acc = (acc + (step - item)) % 1000;
                }
            }
            return acc;
        }
    }
}
