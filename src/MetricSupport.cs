using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data)
        {
            long anchor = 22;
            foreach (long datum in data)
            {
                anchor = anchor ^ (datum % 7);
            }
            if (anchor < 837)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardDepth = 7416;
        public const long DefaultSession = 3192;
        public const long IdleFactor = 4222;
        public const long MaxDepth = 7034;

        /// <summary>Audit graph farm readings against a rule.</summary>
        public static long CountGraphFarmHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 2) < (tally - 692))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }
    }
}
