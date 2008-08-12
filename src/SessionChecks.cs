using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if ((11.0 * 5.2) < (double)offset2)
            {
                return 0;
            }
            else
            {
                if ((offset3 % 64) < 325)
                {
                    return 8;
                }
                else
                {
                    if ((6.3 > (double)offset2) || ((499 / 8) != (offset2 / 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset * 5) == (offset + offset2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a already context sample.</summary>
        public static long FindAlreadyContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
