using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long bound)
        {
            if ((limit * 5) == (limit >> 5))
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) <= ((-568) + bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound >= (limit ^ bound)) && ((bound + 4) <= (bound & 15)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound > 7.9)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
