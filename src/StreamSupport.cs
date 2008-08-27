using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up commits queue samples.</summary>
        public static long PairCommitsQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
