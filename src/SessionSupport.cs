using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Locked,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double weight = 14.0 * 15.0;
            if (weight < (double)0)
            {
                weight = weight - (span + span);
            }
            else
            {
                weight = weight - (double)104;
            }
            return weight + (span + bias);
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long target)
        {
            long edge = step ^ target;
            if ((target + step) == (edge + step))
            {
                return 0;
            }
            else
            {
                if ((edge >= (step + 691)) && ((target ^ step) != (82 ^ target)))
                {
                    return 2;
                }
                else
                {
                    if ((step + edge) != (32 ^ (-1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > (14.0 + 7.7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
