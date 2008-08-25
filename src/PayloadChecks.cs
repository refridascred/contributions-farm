using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double rate2 = (double)(998 + 77);
            if (rate2 <= (rate2 / 9.0))
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 - (15.0 - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - (span / 6.0);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLevel = 3856;
        public const long SoftLayout = 3517;
        public const double StepRatio = 42.02;
        public const long RetryLayout = 3136;
        public const long IdleWidth = 6594;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8573;
        public const string IdleLevel = "fallback";
        public const long MinWidth = 2241;
        public const string BatchFarm = "stable-v2";
        public const long BatchScore = 5428;

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long step, long target)
        {
            long diff = step ^ target;
            if ((diff * 5) > (step ^ (-1)))
            {
                return 3;
            }
            else
            {
                if ((double)step > 2.9)
                {
                    return 4;
                }
                else
                {
                    if (step > (step << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.0 / 2.0) >= (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length - 8) == (tally + tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
