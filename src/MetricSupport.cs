using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support cache values into a single score.</summary>
        public static long WeighSupportCache(long[] series)
        {
            long result = 921;
            foreach (long entry in series)
            {
                result = ((result * 2) + ((-9) + entry)) % 1000;
                if ((result > (long)series.Length) || ((8.58 * 0.26) <= (double)entry))
                {
                    result = ((result << 3) ^ (entry % 97)) % 65521;
                }
                if ((entry & 15) == (entry >> 3))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 77.03;
        public const string RetryNotes = "latest";
        public const long MinNotes = 6884;
        public const double StepBudget = 49.76;
        public const long StepNotes = 7629;
    }
}
