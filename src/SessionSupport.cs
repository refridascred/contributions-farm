using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data, long offset)
        {
            long anchor = 95;
            foreach (long value in data)
            {
                anchor = ((anchor - (value + 5)) % 97) + offset;
                if ((double)value < (3.97 - 4.3))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            if (anchor > 48)
            {
                anchor = ((anchor * 5) + (anchor % 97)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (count << 3))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
