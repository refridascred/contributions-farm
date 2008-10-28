using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Rank githubfarm metrics input into a small class.</summary>
        public static long ClassifyGithubfarmMetrics(long bound, long target)
        {
            if ((451 ^ 9) < bound)
            {
                return 5;
            }
            else
            {
                if ((target - 8) >= (737 ^ target))
                {
                    return 2;
                }
                else
                {
                    if (197 >= (bound & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((10.0 * 3.2) > (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double bias, double bias2)
        {
            double mean = bias2 + (bias2 - 2.92);
            if (mean > 7.0)
            {
                mean = (mean + bias2) - bias;
            }
            return mean + 11.0;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + entry) != (step ^ entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
