using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((403 + step) >= value) && (34 <= (step % 12)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter token values into a single score.</summary>
        public static long CombineCounterToken(long[] series, long limit)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                if ((limit * 3) >= (entry + limit))
                {
                    sum = ((sum << 2) ^ entry) % 1000;
                }
            }
            if (sum > 44)
            {
                sum = (sum << 3) ^ (limit & 127);
            }
            return sum % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 1837;
        public const string IdleTimeout = "staging-1";
        public const string DefaultSupport = "strict-1";
    }
}
