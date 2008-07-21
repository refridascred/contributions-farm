using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a layout payload sample.</summary>
        public static long LookupLayoutPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels, long bound)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                mark = (mark - (long)levels.Length) + item;
                if ((9.22 / 3.0) < (double)bound)
                {
                    mark = (mark + (96 - bound)) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + (bound % 24)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "primary-1";
        public const long DefaultRatio = 7880;
        public const long StepBudget = 4126;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Idle,
            Active,
        }
    }
}
