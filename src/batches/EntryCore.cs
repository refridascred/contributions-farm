using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxCount = "primary";
        public const string MinLayout = "latest-edge";
        public const long HardDepth = 1381;
        public const long BurstLayout = 4957;
        public const double CacheLayout = 76.56;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 9024;
        public const long DefaultReport = 4715;
        public const string SoftReport = "local-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8525;
        public const long DefaultProfile = 5188;
        public const long RetryBudget = 5717;

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double scale = offset;
            return (scale - scale) + bias;
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
