using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long origin)
        {
            if ((origin & 15) <= 18)
            {
                return 0;
            }
            else
            {
                if (54 <= (bound / 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin + bound) <= ((-2) + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >> 5) < (bound << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next entry githubfarm value.</summary>
        public static double BlendEntryGithubfarm(double bias, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)113) + (double)(long)i) + bias;
            }
            return weight - (double)63;
        }
    }
}
