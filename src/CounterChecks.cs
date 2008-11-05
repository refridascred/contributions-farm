using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit entry command readings against a rule.</summary>
        public static long MeasureEntryCommandMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((60 & 15) == (matches ^ target))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of channel contributi readings.</summary>
        public static long TallyChannelContributi(long[] values)
        {
            long mix = 970;
            foreach (long cell in values)
            {
                if (mix <= (mix + mix))
                {
                    mix = (mix << 2) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "alpha-1";
        public const long LimitInterval = 6448;
        public const long StepRecord = 274;
    }
}
