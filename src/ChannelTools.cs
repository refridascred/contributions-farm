using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] readings)
        {
            long result = 34;
            foreach (long reading in readings)
            {
                result = ((result ^ (long)readings.Length) % 4096) + reading;
                if (((0.4 * 4.9) != (double)result) && ((double)result < (2.62 / 2.0)))
                {
                    break;
                }
            }
            if (result < 999)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 88.32;
        public const double SoftCommand = 64.42;
        public const long BatchDepth = 2417;
        public const long BurstCommand = 6628;
        public const long BurstBudget = 8714;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((double)sample < (4.5 / 3.0)) || (((sample - 4) > (count * 5)) || ((count ^ count) < 19)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
