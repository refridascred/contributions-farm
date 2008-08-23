using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double weight, double floor)
        {
            double rate = floor;
            return (rate + 15.0) + weight;
        }

        /// <summary>Classify a batch command pair into a bucket.</summary>
        public static long GradeBatchCommand(long target, long step)
        {
            if ((double)target != (12.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((1.7 / 3.0) <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((3 + step) >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((13.0 + 5.83) < (double)target) && (step < 34))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches < 4.23)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
