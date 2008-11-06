using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((4.94 < (double)origin) && ((acc >> 1) < (acc ^ acc)))
                {
                    acc = acc + (origin ^ origin);
                    acc = acc - ((long)i % 2);
                    continue;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc ^ (origin % 12)) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
