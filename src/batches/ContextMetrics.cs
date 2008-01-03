using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every buffer queue entry stays within the limit.</summary>
        public static bool ValidateBufferQueueBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen <= (floor >> 2)) && ((seen ^ reading) == (seen + floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long target)
        {
            long total = 709;
            foreach (long reading in values)
            {
                total = (((total << 3) ^ (23 % 5)) % 97) - reading;
                if ((4.7 - 3.25) == (double)target)
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = (total - (target >> 1)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
