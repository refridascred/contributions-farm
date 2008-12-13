using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 - (scale - scale2)) + span;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxInterval = 0.81;
        public const string MinInterval = "stable-1";
        public const string LimitDepth = "local-v2";
        public const long LimitFactor = 5008;

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double mean = 4.1;
            if (mean > (double)40)
            {
                mean = (mean - (mean - 3.4)) - ratio;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (2.35 + floor);
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double mean = (3.2 - bias) + (4.54 * 14.0);
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)(long)i) + scale;
            }
            return mean + mean;
        }

        /// <summary>Rank editor command input into a small class.</summary>
        public static long RankEditorCommand(long origin, long step)
        {
            long gap = origin ^ step;
            if (step < (step - (-23)))
            {
                return 1;
            }
            else
            {
                if (step < gap)
                {
                    return 2;
                }
                else
                {
                    if (((5.0 + 10.0) < (double)origin) && (43 > (gap + gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
