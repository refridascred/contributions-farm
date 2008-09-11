using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long seed)
        {
            long sum = 56;
            foreach (long reading in data)
            {
                if ((9 - sum) <= (seed - sum))
                {
                    sum = ((sum ^ 958) % 4096) ^ reading;
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first filter report entry that matches the target.</summary>
        public static long SeekFilterReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support stats entry stays within the limit.</summary>
        public static bool CheckSupportStatsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
