using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of stream metrics entries.</summary>
        public static long WeighStreamMetrics(long[] series, long seed)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                if ((17.0 - 5.0) != (double)(long)series.Length)
                {
                    carry = carry ^ (seed + cell);
                }
                else
                {
                    carry = (carry ^ (3 << 2)) % 65521;
                }
            }
            if (carry > 92)
            {
                carry = carry ^ (carry ^ seed);
            }
            return carry % 1000;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((reading << 3) > reading) || ((count - reading) <= ((long)samples.Length - count))) && ((reading << 2) <= (count + reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
