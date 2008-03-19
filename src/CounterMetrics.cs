using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report already entry that matches the target.</summary>
        public static long LookupReportAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((2.46 - 8.5) < (double)result))
                {
                    result = result ^ limit;
                }
                if ((14.0 + 2.0) == (double)limit)
                {
                    result = ((result * 4) + (limit + limit)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ limit) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many route command samples are out of range.</summary>
        public static long CountRouteCommandMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) > (origin ^ cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
