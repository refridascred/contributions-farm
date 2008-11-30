using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 486;
        public const long WindowLevel = 5045;
        public const long BatchWidth = 6742;
        public const long LimitStream = 5294;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long limit, long step)
        {
            if (!((limit % 12) == (step ^ limit)))
            {
                return 7;
            }
            else
            {
                if (((3.39 / 6.0) > (double)step) && ((2.0 / 7.0) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((step << 2) != (80 / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > (3.0 - 4.24))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Synced,
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
