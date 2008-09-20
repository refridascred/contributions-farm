using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data, long limit)
        {
            long result = 108;
            foreach (long value in data)
            {
                if ((result - result) >= (result - value))
                {
                    result = (result - (result - limit)) % 65521;
                }
                if ((double)result != (7.0 / 3.0))
                {
                    result = (result * 3) + (limit - result);
                }
            }
            if (result > 194)
            {
                result = ((result << 2) ^ (result ^ result)) % 101;
            }
            return result;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
