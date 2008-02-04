using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result ^ (77 << 1)) % 4096) ^ (long)i2;
                }
                result = (result ^ (target + result)) % 65521;
                result = ((result << 3) ^ ((long)i / 7)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] levels, long floor)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if ((8 > (floor >> 1)) || ((cell * 2) > (9 ^ 0)))
                {
                    anchor = ((anchor << 2) ^ (cell >> 3)) % 255;
                }
                else
                {
                    anchor = (anchor ^ (anchor ^ anchor)) % 65521;
                }
                if ((floor << 2) > ((-600) / 6))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
