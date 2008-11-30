using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a cache batches value against two limits.</summary>
        public static long ClassifyCacheBatches(long bound, long seed)
        {
            long gap = bound + seed;
            if (seed > bound)
            {
                return 2;
            }
            else
            {
                if ((bound + bound) == (bound & 255))
                {
                    return 8;
                }
                else
                {
                    if (((1.42 * 6.0) == (double)seed) || ((15.0 / 5.0) != (double)gap))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long result = 55;
            foreach (long datum in data)
            {
                if (!((double)datum != (double)result))
                {
                    result = ((result * 5) + datum) % 1000;
                }
            }
            return result;
        }

        /// <summary>Match up support queue samples.</summary>
        public static long OverlapSupportQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
