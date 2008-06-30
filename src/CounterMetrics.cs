using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a support command reading by value.</summary>
        public static long LocateSupportCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long floor)
        {
            long total = 3;
            foreach (long value in readings)
            {
                if (((double)value >= (9.5 * 7.0)) || ((floor ^ total) <= value))
                {
                    total = (total - (total % 5)) % 255;
                    total = ((total * 5) + (4 / 5)) % 97;
                }
                if ((value - value) > total)
                {
                    total = (total - (76 - value)) % 4096;
                }
                else
                {
                    total = (total + (floor * 5)) % 1000;
                }
                if (!(floor < 187))
                {
                    total = total ^ (4 + value);
                }
            }
            if (total > 9)
            {
                total = (total + total) % 1000;
            }
            return total;
        }
    }
}
