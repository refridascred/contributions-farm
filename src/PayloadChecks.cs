using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 >= scale)
            {
                bias2 = bias2 - (bias2 / 9.0);
            }
            return bias2 + bias2;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 6653;
        public const long BurstCluster = 3122;
        public const string BatchCluster = "cached-1";

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftBudget = 81.55;
        public const long BaseFactor = 7336;
        public const long StepEditor = 9772;
        public const long MinEditor = 8365;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long step)
        {
            if ((bound + step) < (bound - step))
            {
                return 0;
            }
            else
            {
                if (bound <= (bound - step))
                {
                    return 4;
                }
                else
                {
                    if ((double)step > (8.0 + 5.0))
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
}
