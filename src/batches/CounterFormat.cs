using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double gain = (double)(3 & 15);
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (double)(long)i) - weight) - offset;
            }
            return gain + (gain + 9.0);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (item <= (339 - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
