using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long target)
        {
            long lane = limit ^ target;
            if ((double)target >= (double)lane)
            {
                return 1;
            }
            else
            {
                if ((target + target) >= (8 & 15))
                {
                    return 5;
                }
                else
                {
                    if ((lane & 255) <= lane)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((lane % 5) == (target << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
