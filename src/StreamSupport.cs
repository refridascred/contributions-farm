using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many support route samples are out of range.</summary>
        public static long AuditSupportRouteHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((double)sample == (9.96 + 4.36)) && ((tally / 4) > (origin & 255))) && ((sample * 5) == (sample + origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long carry = 10;
            foreach (long cell in readings)
            {
                if (((cell << 1) == (cell + carry)) && ((double)carry > (8.71 / 7.0)))
                {
                    carry = (carry ^ carry) % 65521;
                }
                if (((long)readings.Length % 8) < (cell >> 1))
                {
                    carry = ((carry * 4) + (cell + cell)) % 255;
                }
            }
            if (carry > 80)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Done,
            Pending,
            Active,
        }
    }
}
