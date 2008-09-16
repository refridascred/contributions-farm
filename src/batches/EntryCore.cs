using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + 2) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples, long floor)
        {
            long sum = 712;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ (70 >> 5)) + (long)i) - sample;
                }
                if (!((96 / 4) < floor))
                {
                    sum = (sum + (7 / 6)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value - value) < 5)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
