using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long bound)
        {
            if ((bound * 4) >= (floor & 127))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor / 5) == (floor / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound >> 2) < (bound % 100)) || ((double)floor >= (16.0 / 3.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools commits samples are out of range.</summary>
        public static long TallyToolsCommitsMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum & 63) > datum)
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Closed,
            New,
            Draft,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double load = (double)81 / 9.0;
            if (load <= 1.5)
            {
                load = load + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (bias * 7.48);
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
