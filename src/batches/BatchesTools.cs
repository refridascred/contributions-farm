using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            New,
            Idle,
            Locked,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            long step = bound ^ origin;
            if ((bound / 4) > step)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < 835)
                {
                    return 7;
                }
                else
                {
                    if (!(origin > (step % 12)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double mean = (double)(694 & 1);
            if (mean >= (scale * 1.3))
            {
                mean = mean - (scale * 4.7);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (scale - bias)) + (double)(long)i;
            }
            return mean + (3.3 + 9.4);
        }
    }
}
