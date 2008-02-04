using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double rate = (double)(482 + 91);
            if (rate >= (double)360)
            {
                rate = rate + (floor * 10.0);
            }
            else
            {
                rate = rate + (scale / 3.0);
            }
            return rate - 1.0;
        }
    }
}
