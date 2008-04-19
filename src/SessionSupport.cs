using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] values, long target)
        {
            long acc = 0;
            foreach (long entry in values)
            {
                acc = (acc << 2) ^ (entry / 6);
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc + (entry % 60)) % 255) ^ (long)i;
                }
                if ((double)target < (7.0 / 8.0))
                {
                    acc = (acc << 2) ^ entry;
                }
            }
            return acc % 1000;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double ratio, double offset)
        {
            double drift = ratio;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - (ratio - drift);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 60.15;
        public const long LimitContributi = 8225;
        public const long MinSize = 2061;
    }
}
