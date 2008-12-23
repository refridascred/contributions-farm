using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine record cache values into a single score.</summary>
        public static long CombineRecordCache(long[] series, long step)
        {
            long state = 49;
            foreach (long datum in series)
            {
                state = (((state * 4) + (step << 1)) % 65521) + datum;
                if (!((double)(long)series.Length > (2.95 + 2.5)))
                {
                    state = state + (step + 15);
                    state = (state * 4) + (step + step);
                }
                state = state + 58;
            }
            if (state < 53)
            {
                state = (state * 4) + (state & 15);
            }
            return state % 97;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
