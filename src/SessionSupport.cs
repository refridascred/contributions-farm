using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 3534;
        public const double HardCounter = 80.28;
        public const long IdleSpan = 5260;
        public const long StepCounter = 7865;
        public const long SoftCounter = 8236;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Locked,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double gain, double floor)
        {
            double ratio = (double)(1 % 7);
            if (ratio <= floor)
            {
                ratio = ratio - (double)24;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio + (double)128;
        }
    }
}
