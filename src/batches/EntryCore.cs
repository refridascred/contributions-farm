using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Check that every layout farm entry stays within the limit.</summary>
        public static bool ValidateLayoutFarmBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double rate = 4.3;
            if (rate > (weight - 2.7))
            {
                rate = (rate - (double)4) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)8) + (double)(long)i;
            }
            return rate + (weight / 4.0);
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((1 / 9) >= (9 ^ bound))
                {
                    acc = (acc ^ ((long)i << 2)) % 97;
                    acc = (acc + (2 + (long)i)) % 101;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
