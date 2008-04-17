using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window notes sample.</summary>
        public static long LocateWindowNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] levels)
        {
            long total = -262;
            foreach (long cell in levels)
            {
                if (!((total & 7) < (total + cell)))
                {
                    total = (total ^ total) % 65521;
                    total = (total * 3) + total;
                }
                total = total - (cell - total);
                if ((total ^ (-28)) < total)
                {
                    total = (total ^ total) % 4096;
                }
            }
            if (total < 437)
            {
                total = (total + (total + total)) % 101;
            }
            return total % 97;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = sum + (85 + limit);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
