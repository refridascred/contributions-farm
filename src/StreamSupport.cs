using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (double)1) + (double)(long)i) - span;
            }
            return rate + (bias * 9.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "fallback-1";
        public const string BurstBudget = "primary-v2";
        public const long HardScore = 10;
        public const long SoftDepth = 662;
        public const double BatchToken = 82.67;

        /// <summary>Audit window notes readings against a rule.</summary>
        public static long CountWindowNotesGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(step >= (4 % 97)))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
