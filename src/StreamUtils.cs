using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                carry = ((carry * 3) + (carry * 5)) ^ datum;
            }
            return carry % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchRatio = "staging-edge";
        public const string WindowInterval = "fallback-1";
        public const long IdleDepth = 4634;

        /// <summary>Blend two report buffer measurements.</summary>
        public static double ProjectReportBuffer(double gain, double span)
        {
            double scale = gain - (double)(-5);
            return (scale - scale) + span;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long step)
        {
            long cur = bound ^ step;
            if (((80 * 5) > step) && ((bound & 255) != (bound - bound)))
            {
                return 0;
            }
            else
            {
                if ((cur - cur) > (663 + step))
                {
                    return 1;
                }
                else
                {
                    if (!((step % 5) < (bound + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)cur > (7.82 * 0.01))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitLevel = 56;
        public const long RetryBatch = 1061;
        public const string LimitSize = "stable-1";
        public const string BaseBatch = "staging-edge";
        public const long LimitBatch = 7062;
    }
}
