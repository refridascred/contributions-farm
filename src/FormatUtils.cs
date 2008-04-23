using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Pending,
            Failed,
            Closed,
            New,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((15.0 + 0.9) >= (double)entry)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((16 - item) > (233 << 3)) || ((item & 63) <= (item - item))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                if (origin > (score + score))
                {
                    score = score ^ (long)i;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank order stream input into a small class.</summary>
        public static long SortOrderStream(long limit, long floor)
        {
            long next = limit - floor;
            if ((next & 7) > limit)
            {
                return 6;
            }
            else
            {
                if ((double)limit >= 1.45)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (count + 7))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
