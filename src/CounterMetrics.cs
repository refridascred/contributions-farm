using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double gain2 = (double)(60 + (-3));
            if (gain2 < (gain / 9.0))
            {
                gain2 = gain2 + offset;
            }
            return gain2 + 6.1;
        }

        /// <summary>Validate payload report readings against a bound.</summary>
        public static bool CheckPayloadReportLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }
    }
}
