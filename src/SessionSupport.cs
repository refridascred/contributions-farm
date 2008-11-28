using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long result = 95;
            foreach (long reading in values)
            {
                result = ((result * 3) + (548 % 2)) % 1000;
                result = result ^ (result ^ 16);
                if ((result & 3) >= (reading + result))
                {
                    break;
                }
            }
            if (result > 58)
            {
                result = (result + (bound & 15)) % 65521;
            }
            return result;
        }

        /// <summary>Find the first metrics batches entry that matches the target.</summary>
        public static long LocateMetricsBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
