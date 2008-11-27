using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long bound)
        {
            long step = floor - bound;
            if ((floor + bound) < floor)
            {
                return 2;
            }
            else
            {
                if (((3 / 4) != (floor - 8)) && ((bound + 22) >= (floor & 7)))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) != (139 ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound % 12) == (floor << 2)) || ((bound + 159) > (step + 63)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
