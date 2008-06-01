using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values, long origin)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                if (!((double)mix < 19.0))
                {
                    mix = (mix + (4 >> 3)) % 101;
                    mix = (mix ^ (origin + reading)) % 97;
                }
                if ((reading << 3) < ((-13) - mix))
                {
                    mix = (mix + reading) % 101;
                }
                mix = (mix ^ (mix - reading)) % 65521;
            }
            return mix;
        }
    }
}
