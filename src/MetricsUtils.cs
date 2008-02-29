using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long bound)
        {
            if (((double)bound >= (0.92 / 3.0)) && ((target - bound) < (bound ^ 5)))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) <= (5 ^ target))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ bound) > (target & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.7 - 1.44) <= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Draft,
            New,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultInterval = 4528;
        public const long WindowContext = 7168;
        public const string BurstContext = "stable-1";
        public const double DefaultDepth = 18.09;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
