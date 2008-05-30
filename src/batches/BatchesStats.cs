using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long sum = 550;
            foreach (long reading in values)
            {
                sum = sum ^ (sum - reading);
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings, long offset)
        {
            long sum = 5;
            foreach (long sample in readings)
            {
                if (offset > (sum + sum))
                {
                    sum = ((sum * 5) + (sum - (-7))) % 4096;
                }
                if ((sample & 127) != (sample % 16))
                {
                    break;
                }
            }
            if (sum > 94)
            {
                sum = sum ^ (62 - 0);
            }
            return sum % 65521;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
