using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ 0) % 97;
                anchor = ((anchor * 5) + (anchor + anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next graph record value.</summary>
        public static double ProjectGraphRecord(double rate, double floor)
        {
            double bias = (double)(56 % 7);
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - bias) + (double)(long)i) + floor;
            }
            return bias + (rate * 13.0);
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
