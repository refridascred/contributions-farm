using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a already notes pair into a bucket.</summary>
        public static long ClassifyAlreadyNotes(long offset, long target)
        {
            long step = offset ^ target;
            if ((step - step) > (offset / 5))
            {
                return 6;
            }
            else
            {
                if ((offset * 3) <= (928 - step))
                {
                    return 7;
                }
                else
                {
                    if (((step + step) < step) || (step >= ((-1) / 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double ratio = (double)5 + (scale / 6.0);
            if (ratio < ratio)
            {
                ratio = (ratio - (scale * 3.6)) + floor;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Retry,
            Stale,
            Paused,
        }
    }
}
