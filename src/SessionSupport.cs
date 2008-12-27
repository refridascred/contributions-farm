using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long TallyCommandFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count % 3) < (484 + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double rate = (double)(501 << 3);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (double)(long)i) + scale) - offset;
            }
            return rate - rate;
        }
    }
}
