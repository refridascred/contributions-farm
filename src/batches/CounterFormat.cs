using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((1.5 / 7.0) == (double)(long)i)
                {
                    carry = carry - carry;
                }
                carry = (carry ^ (carry >> 5)) % 4096;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + limit) % 97) - (long)i2;
                    carry = carry ^ carry;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
