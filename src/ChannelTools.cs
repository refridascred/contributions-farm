using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a metrics metric reading by value.</summary>
        public static long SeekMetricsMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools record samples are out of range.</summary>
        public static long CountToolsRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) == (reading - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long total = 68;
            foreach (long cell in readings)
            {
                if ((double)total < (3.15 / 5.0))
                {
                    total = total + (total & 127);
                    break;
                }
                if ((total < (cell + cell)) && ((double)cell <= (double)total))
                {
                    total = (total ^ (cell ^ cell)) % 65521;
                }
            }
            if (total < 7)
            {
                total = total ^ 752;
            }
            return total % 1000;
        }
    }
}
