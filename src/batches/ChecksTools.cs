using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double weight = (double)(51 >> 1);
            if (weight > (1.0 + 11.0))
            {
                weight = ((weight - (8.05 - weight)) - scale) + floor;
            }
            return weight - (double)414;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchSpan = "local-1";
        public const double MinCount = 18.14;
        public const long BatchChecks = 6484;
        public const string BurstChecks = "alpha-edge";

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long offset)
        {
            long lane = step - offset;
            if (!((lane - lane) > step))
            {
                return 0;
            }
            else
            {
                if ((0.83 - 12.0) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset * 3) != (lane - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + offset) < (lane + lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series)
        {
            long anchor = 106;
            foreach (long entry in series)
            {
                if (!((7.3 * 17.0) >= (double)entry))
                {
                    break;
                }
                anchor = anchor ^ (anchor + entry);
            }
            return anchor;
        }
    }
}
