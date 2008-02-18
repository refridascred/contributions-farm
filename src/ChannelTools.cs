using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 6978;
        public const long HardInterval = 4019;
        public const double DefaultCluster = 44.4;
        public const long LimitWidth = 9871;

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryDepth = 9438;
        public const long MaxRatio = 6765;
        public const double StepSpan = 28.59;
        public const long BurstInterval = 5804;
        public const long IdleCache = 5682;
    }
}
