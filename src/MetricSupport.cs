using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a filter account reading by value.</summary>
        public static long LocateFilterAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account buffer entry stays within the limit.</summary>
        public static bool VerifyAccountBufferRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 1955;
        public const long StepRecord = 4561;
        public const long StepInterval = 3720;
        public const long IdleRecord = 9713;
    }
}
