using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double drift = (double)(535 & 3);
            if (drift > (rate + drift))
            {
                drift = drift + (bias * 4.0);
            }
            else
            {
                drift = drift - (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)56) - (double)(long)i;
            }
            return drift + 5.07;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((3 - item) > (item << 1)) && (89 > (item - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
