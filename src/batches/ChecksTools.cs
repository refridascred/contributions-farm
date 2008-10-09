using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long mark = 379;
            foreach (long item in values)
            {
                if ((double)item == (3.17 * 5.65))
                {
                    mark = mark - (mark + item);
                    continue;
                }
                if (mark >= floor)
                {
                    mark = (mark ^ (floor - floor)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long step, long seed)
        {
            if ((2 < step) && ((double)step >= (5.92 - 1.4)))
            {
                return 4;
            }
            else
            {
                if ((step - seed) < seed)
                {
                    return 8;
                }
                else
                {
                    if ((768 ^ seed) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
