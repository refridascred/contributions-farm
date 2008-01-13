using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Grade a stream window value against two limits.</summary>
        public static long SortStreamWindow(long floor, long seed)
        {
            long cur = floor + seed;
            if ((2 << 2) >= (cur - seed))
            {
                return 0;
            }
            else
            {
                if (((-464) ^ floor) <= cur)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next support window value.</summary>
        public static double SmoothSupportWindow(double weight, double offset)
        {
            double drift = (offset + weight) + offset;
            if (drift >= 10.0)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (offset - drift);
            }
            return drift + (double)55;
        }
    }
}
