using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values, long bound)
        {
            long total = 276;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (entry * 3)) % 97;
                if (bound >= (bound + bound))
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = (total << 2) ^ (total + 8);
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxSize = 8289;
        public const string HardChannel = "stable";
        public const long MinChannel = 4109;
        public const double RetryChannel = 63.34;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (origin - origin)) % 1000;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long result = -39;
            foreach (long value in items)
            {
                if ((value & 127) == (value ^ value))
                {
                    result = (result - (value - result)) % 65521;
                }
                else
                {
                    result = (result + (1 + result)) % 65521;
                }
            }
            if (result < (-57))
            {
                result = (result ^ ((long)items.Length ^ result)) % 101;
            }
            return result;
        }
    }
}
