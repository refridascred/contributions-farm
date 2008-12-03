using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Done,
            Active,
            Retry,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long limit)
        {
            long span = step + limit;
            if ((double)step <= (7.33 * 7.66))
            {
                return 0;
            }
            else
            {
                if ((span - span) < limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double weight, double offset)
        {
            double drift = offset - weight;
            if (drift >= (offset / 7.0))
            {
                drift = drift - (1.1 - 5.08);
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (offset - weight);
        }
    }
}
