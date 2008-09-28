using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a context commits sample.</summary>
        public static long LocateContextCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double weight = (offset - 0.3) / 4.0;
            if (weight > 2.21)
            {
                weight = weight + (weight - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)92) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
