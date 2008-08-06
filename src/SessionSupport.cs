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

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "strict-v2";
        public const long BatchWindow = 5474;
        public const double IdleWindow = 53.15;
        public const long HardCount = 977;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((double)offset <= 4.8) || ((double)offset <= (4.0 + 6.0)))
                {
                    mark = (mark - (61 - offset)) % 4096;
                }
                if (((long)i ^ (long)i) == (long)i)
                {
                    mark = (mark << 2) ^ ((long)i * 4);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
