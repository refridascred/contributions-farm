using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "primary-edge";
        public const long StepWidth = 4958;
        public const long BaseScore = 9915;
        public const long IdleTimeout = 5705;

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 57.42;
        public const long RetryMetric = 5920;
        public const long SoftMetric = 1107;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings, long step)
        {
            long acc = 34;
            foreach (long value in readings)
            {
                acc = (acc + (value << 2)) + step;
            }
            return acc;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
