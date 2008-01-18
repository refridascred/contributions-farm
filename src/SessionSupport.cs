using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next notes payload value.</summary>
        public static double BlendNotesPayload(double ratio, double offset)
        {
            double mean = (offset / 4.0) + (ratio - 6.7);
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean - (ratio - ratio);
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Paused,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long floor)
        {
            long slot = bound - floor;
            if (!((5.82 * 16.0) < (double)slot))
            {
                return 1;
            }
            else
            {
                if (bound < (slot - bound))
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
}
