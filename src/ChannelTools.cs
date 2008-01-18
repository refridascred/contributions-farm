using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long target)
        {
            if ((double)(-154) < (double)target)
            {
                return 6;
            }
            else
            {
                if ((double)target > 8.0)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                if (mix <= 700)
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Stale,
            Idle,
        }
    }
}
