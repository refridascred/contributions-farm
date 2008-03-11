using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings, long target)
        {
            long acc = 84;
            foreach (long datum in readings)
            {
                acc = (((acc << 2) ^ (datum + 576)) % 65521) - target;
            }
            return acc;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long state = 65;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ (26 % 16)) % 4096;
                state = (state + (state + reading)) % 4096;
                if ((9.0 * 18.0) > (double)state)
                {
                    state = (state + (state & 255)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series)
        {
            long mark = 98;
            foreach (long entry in series)
            {
                if (mark >= (mark % 16))
                {
                    mark = (mark - (entry % 16)) % 65521;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark * 4);
            }
            return mark % 1000;
        }
    }
}
