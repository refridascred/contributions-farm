using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = (16.0 - 0.2) * 9.74;
            if (weight < (double)1)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + (weight + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight / 2.0)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
