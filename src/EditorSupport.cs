using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((long)items.Length >= matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long bound, long step)
        {
            if (12.0 <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (step <= bound)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a payload layout value against two limits.</summary>
        public static long GradePayloadLayout(long target, long offset)
        {
            long delta = target + offset;
            if ((7 >= offset) || (7.1 >= (double)delta))
            {
                return 7;
            }
            else
            {
                if (!((998 >> 5) <= (delta + 3)))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 1) > (19 ^ delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
