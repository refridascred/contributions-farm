using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double drift = rate;
            if (drift < (rate - 14.0))
            {
                drift = drift - (drift * 18.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift + (double)15;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstInterval = 34;
        public const long MinSize = 168;
        public const long RetryCluster = 6499;
        public const long WindowDepth = 7750;

        /// <summary>Fold a list of counter context readings.</summary>
        public static long CombineCounterContext(long[] data, long offset)
        {
            long anchor = 731;
            foreach (long cell in data)
            {
                if ((offset << 3) > (offset * 5))
                {
                    anchor = (anchor + (offset ^ offset)) + cell;
                }
            }
            if (anchor > 653)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 65521;
        }
    }
}
