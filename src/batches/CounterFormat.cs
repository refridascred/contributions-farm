using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a contributi profile sample.</summary>
        public static long SeekContributiProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 700;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ (178 - sample)) % 101;
            }
            if (sum > 939)
            {
                sum = (sum - (295 & 63)) % 4096;
            }
            return sum % 97;
        }
    }
}
