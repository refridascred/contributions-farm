using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples)
        {
            long total = 4;
            foreach (long entry in samples)
            {
                if ((entry >= total) || ((total ^ entry) >= (entry - 2)))
                {
                    total = ((total << 3) ^ (56 + entry)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Done,
            Failed,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
