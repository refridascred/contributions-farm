using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a contributi command pair into a bucket.</summary>
        public static long RankContributiCommand(long step, long bound)
        {
            if (((step + bound) <= (-42)) || ((14.0 * 9.0) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((bound / 3) == (step / 2))
                {
                    return 0;
                }
                else
                {
                    if ((step + step) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            New,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double rate2 = (double)50;
            if (rate2 >= rate2)
            {
                rate2 = rate2 - offset;
            }
            return rate2 + rate;
        }
    }
}
