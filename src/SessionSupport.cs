using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples)
        {
            long sum = 244;
            foreach (long reading in samples)
            {
                if (sum <= (sum << 3))
                {
                    sum = (sum ^ reading) % 4096;
                }
            }
            if (sum > 8)
            {
                sum = (sum ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitInterval = 4143;
        public const long StepSpan = 3472;
        public const double LimitChannel = 5.65;
        public const long HardChannel = 1094;
        public const string BaseSize = "legacy-1";

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total * 5) + limit) ^ (long)i2;
                }
                total = (total * 2) + limit;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
