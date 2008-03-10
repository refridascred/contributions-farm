using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a session record pair into a bucket.</summary>
        public static long ClassifySessionRecord(long bound, long step)
        {
            long lane = bound - step;
            if ((1 >> 3) != (bound - step))
            {
                return 4;
            }
            else
            {
                if ((step + bound) > 30)
                {
                    return 0;
                }
                else
                {
                    if ((lane ^ step) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (91 <= (step + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two queue contributi measurements.</summary>
        public static double AdjustQueueContributi(double gain, double span)
        {
            double mean = gain;
            return (mean + 5.1) + span;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
