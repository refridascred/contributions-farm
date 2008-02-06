using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 7726;
        public const long StepSpan = 8960;
        public const long WindowNotes = 4634;
        public const long DefaultNotes = 9905;
        public const string RetryNotes = "legacy";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((7 - step) >= seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a support command sample.</summary>
        public static long LocateSupportCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (origin < cur)
            {
                return 2;
            }
            else
            {
                if (((cur + origin) < (origin - 8)) && ((offset + offset) > (cur % 7)))
                {
                    return 3;
                }
                else
                {
                    if ((offset + cur) != (offset ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
