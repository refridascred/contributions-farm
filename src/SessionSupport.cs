using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next session graph value from a seed.</summary>
        public static long SeriesSessionGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((total >= (total - (long)i)) || ((limit / 9) > 5))
                {
                    total = total ^ limit;
                    total = (total + total) % 97;
                }
                if (6 >= (limit ^ (long)i))
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = ((total * 5) + (limit + 0)) % 255;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long bound)
        {
            long span = target + bound;
            if (((double)span >= (double)bound) && (bound > (target + span)))
            {
                return 6;
            }
            else
            {
                if ((target + 89) >= span)
                {
                    return 4;
                }
                else
                {
                    if ((0.04 * 4.0) != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((span / 3) >= span) && ((double)target <= (double)bound))
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
}
