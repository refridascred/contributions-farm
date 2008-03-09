using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long floor)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if (!((state / 7) >= (7 * 2)))
                {
                    state = ((state + (state % 7)) % 101) + reading;
                }
            }
            if (state < 65)
            {
                state = (state ^ floor) % 101;
            }
            return state;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Validate stream farm readings against a bound.</summary>
        public static bool VerifyStreamFarmRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
