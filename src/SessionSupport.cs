using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long limit)
        {
            long mix = 37;
            foreach (long entry in samples)
            {
                if ((entry << 2) == (999 + mix))
                {
                    mix = (mix * 5) + 36;
                }
            }
            if (mix < 24)
            {
                mix = (mix * 5) + limit;
            }
            return mix;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long mark = -84;
            foreach (long datum in readings)
            {
                mark = mark + mark;
                mark = (mark - (mark + mark)) % 255;
                if ((mark - 89) <= (datum / 5))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Failed,
            Active,
            Done,
        }
    }
}
