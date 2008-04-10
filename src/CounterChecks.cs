using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first account session entry that matches the target.</summary>
        public static long LookupAccountSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session token samples.</summary>
        public static long FoldSessionToken(long[] samples)
        {
            long result = 551;
            foreach (long cell in samples)
            {
                if (!((result / 8) <= (result >> 5)))
                {
                    result = (result + (cell + cell)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (cell >> 3)) % 97;
                }
                if (((cell + cell) > (result - result)) || ((result & 7) >= cell))
                {
                    break;
                }
            }
            if (result > 970)
            {
                result = ((result * 2) + (result >> 1)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultCount = 1034;
        public const string IdleSize = "stable-1";
        public const long MaxQueue = 5971;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            New,
            Locked,
            Done,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
