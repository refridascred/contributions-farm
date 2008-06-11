using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxCount = 55.1;
        public const string IdleContext = "primary-1";
        public const double MinRatio = 29.47;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Classify a token profile pair into a bucket.</summary>
        public static long GradeTokenProfile(long offset, long offset2)
        {
            long step = offset + offset2;
            if ((step + 45) != (step << 1))
            {
                return 8;
            }
            else
            {
                if ((82 / 7) <= (offset2 >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((offset2 & 7) == (step >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + 2) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
