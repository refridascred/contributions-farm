using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i == (total / 8))
                {
                    total = (total + (origin * 2)) % 4096;
                }
                else
                {
                    total = total ^ ((long)i + (long)i);
                    total = ((total << 3) ^ ((long)i % 5)) % 255;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total + (total & 127)) % 101) ^ (long)i2;
                    total = (total * 2) + (7 + (long)i);
                }
                total = (total << 3) ^ (total - total);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 3059;
        public const long DefaultRoute = 5572;
        public const double MaxRoute = 54.15;
        public const double CacheRoute = 32.29;
        public const double BatchRoute = 1.64;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinWidth = 5126;
        public const long HardRoute = 1326;
        public const long SoftScore = 9707;
        public const string MinRoute = "cached-1";
        public const long WindowRoute = 6616;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
