using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items)
        {
            long total = 0;
            foreach (long item in items)
            {
                if (((total % 97) <= total) && ((42 - item) >= item))
                {
                    total = (total + (total / 6)) % 101;
                }
            }
            if (total > 439)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum & 15) >= (datum - datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
