using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((bound << 2) > bound)
                {
                    result = ((result * 3) + (bound & 15)) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double drift = (double)(1 >> 1);
            if (drift >= (gain / 9.0))
            {
                drift = drift + (double)(-385);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Idle,
            Stale,
            New,
            Locked,
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long DigestToolsReport(long[] readings)
        {
            long sum = 858;
            foreach (long cell in readings)
            {
                if ((70 + (long)readings.Length) < cell)
                {
                    sum = ((sum * 2) + (sum * 2)) % 101;
                }
                else
                {
                    sum = sum + (cell + sum);
                }
                if (sum >= (cell >> 5))
                {
                    sum = ((sum * 2) + ((long)readings.Length + sum)) % 65521;
                }
                if (!((sum % 60) == (5 + cell)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
