using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long state = 6;
            foreach (long value in levels)
            {
                if ((state * 5) > (value * 4))
                {
                    state = (state << 3) ^ (value * 4);
                }
                else
                {
                    state = ((state << 2) ^ (state - state)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long step)
        {
            long cur = target + step;
            if (((target >> 3) < target) || ((cur + target) <= (cur - step)))
            {
                return 4;
            }
            else
            {
                if ((61 + target) >= target)
                {
                    return 5;
                }
                else
                {
                    if (cur < target)
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

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every schema notes entry stays within the limit.</summary>
        public static bool VerifySchemaNotesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
