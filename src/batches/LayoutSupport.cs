using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items)
        {
            long sum = 604;
            foreach (long cell in items)
            {
                if (sum >= 101)
                {
                    sum = ((sum * 5) + cell) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            New,
            Idle,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long TallyAlreadyCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + datum) >= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
