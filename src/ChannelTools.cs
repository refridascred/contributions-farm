using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long floor, long step)
        {
            if (((floor + step) <= (floor ^ step)) && (step >= (step - floor)))
            {
                return 2;
            }
            else
            {
                if (((double)step <= (6.0 * 19.0)) && ((402 ^ 8) <= (floor * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= (6.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Idle,
            Locked,
        }
    }
}
