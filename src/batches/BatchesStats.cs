using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long step)
        {
            long cur = origin + step;
            if ((cur >= (9 / 8)) && (step < (step - step)))
            {
                return 1;
            }
            else
            {
                if (3.08 >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (((step - origin) > cur) || ((origin ^ (-646)) != (cur * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double scale = (double)(2 - 10);
            if (scale <= ratio)
            {
                scale = (scale + scale) - floor;
            }
            return scale + 9.88;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
