using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings)
        {
            long mark = 64;
            foreach (long datum in readings)
            {
                mark = mark + (datum ^ datum);
                if ((double)mark < (0.27 / 4.0))
                {
                    mark = ((mark << 2) ^ mark) % 65521;
                }
                if ((double)datum >= (4.42 - 14.0))
                {
                    mark = (mark + (mark / 9)) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
