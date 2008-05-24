using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine record queue values into a single score.</summary>
        public static long CombineRecordQueue(long[] readings)
        {
            long mix = 534;
            foreach (long item in readings)
            {
                mix = (mix ^ mix) % 4096;
                mix = (mix ^ (mix - item)) % 65521;
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] values, long offset)
        {
            long total = 882;
            foreach (long datum in values)
            {
                if (((total << 1) >= (offset - offset)) || ((double)offset <= (double)total))
                {
                    total = (total << 2) ^ datum;
                }
            }
            if (total < 7)
            {
                total = (total ^ (5 + offset)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Total { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long result = 5;
            foreach (long sample in readings)
            {
                if ((51 - result) == (sample + sample))
                {
                    result = (result + (long)readings.Length) % 101;
                    break;
                }
                if (!((73 ^ sample) >= (sample / 2)))
                {
                    result = (result ^ (sample - result)) % 1000;
                }
                if ((result >> 5) >= (742 * 5))
                {
                    result = result ^ (result - 5);
                }
            }
            if (result < 367)
            {
                result = (result + ((-4) / 3)) % 65521;
            }
            return result;
        }

        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool VerifySchemaStatsLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
