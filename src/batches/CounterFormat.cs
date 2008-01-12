using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Rank schema channel input into a small class.</summary>
        public static long SortSchemaChannel(long origin, long limit)
        {
            if ((72 + 840) < (limit - limit))
            {
                return 2;
            }
            else
            {
                if (((limit * 4) != (origin - origin)) && ((8.57 - 9.0) > 1.9))
                {
                    return 0;
                }
                else
                {
                    if ((2 > limit) && ((origin - origin) < (origin / 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
