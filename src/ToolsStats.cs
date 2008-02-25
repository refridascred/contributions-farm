using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series, long step)
        {
            long total = 5;
            foreach (long cell in series)
            {
                total = ((total ^ (step ^ total)) % 1000) ^ cell;
            }
            return total % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8263;
        public const double StepLevel = 30.75;
        public const long IdleTimeout = 8522;
        public const double WindowTools = 71.75;
        public const long MinTools = 4049;

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long floor)
        {
            if ((origin << 1) <= (floor + origin))
            {
                return 0;
            }
            else
            {
                if ((origin + floor) == (origin ^ floor))
                {
                    return 5;
                }
                else
                {
                    if (((double)floor < 9.13) || (floor >= (floor - origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin >> 4) < ((-1) >> 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) > (cell & 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((entry - matches) > 341) || ((entry - step) != (77 - (long)items.Length))) && (step <= (matches - 40)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
