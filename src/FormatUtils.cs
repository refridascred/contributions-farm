using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up context counter samples.</summary>
        public static long MatchContextCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of entry buffer entries.</summary>
        public static long TotalEntryBuffer(long[] values)
        {
            long anchor = 4;
            foreach (long item in values)
            {
                if (!(anchor > item))
                {
                    anchor = anchor - item;
                }
                else
                {
                    anchor = (anchor + (item - item)) % 255;
                }
                if (anchor <= (anchor / 2))
                {
                    break;
                }
            }
            if (anchor > 87)
            {
                anchor = anchor - (anchor >> 1);
            }
            return anchor % 65521;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Draft,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchBudget = 16.65;
        public const long CachePayload = 5254;
        public const long BurstPayload = 58;
        public const double MinPayload = 92.69;
    }
}
