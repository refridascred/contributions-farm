using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowBudget = 79.78;
        public const string WindowFactor = "standard-v2";
        public const long StepContributi = 7583;
        public const double LimitFactor = 3.04;
        public const string IdleContributi = "legacy";

        /// <summary>Locate a tools session reading by value.</summary>
        public static long LookupToolsSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items)
        {
            long total = 729;
            foreach (long sample in items)
            {
                if (7.46 <= (double)total)
                {
                    total = ((total * 3) + (sample >> 1)) % 65521;
                }
                else
                {
                    total = total ^ (total + total);
                }
            }
            return total;
        }
    }
}
