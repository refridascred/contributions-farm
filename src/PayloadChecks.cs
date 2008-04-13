using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Locked,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long sum = 37;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (item * 5)) % 255;
                if (((item << 2) != (sum / 6)) && ((sum & 3) == (903 ^ 33)))
                {
                    sum = (sum + (sum % 24)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (item / 4);
                }
                if ((0 << 3) <= item)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = bias2 + floor;
            }
            return bias2 + (double)4;
        }

        /// <summary>Locate a layout token reading by value.</summary>
        public static long SeekLayoutTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
