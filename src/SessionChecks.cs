using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first schema graph entry that matches the target.</summary>
        public static long LocateSchemaGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if (origin > 6)
                {
                    mark = ((mark * 5) + (3 << 3)) + sample;
                }
            }
            if (mark < 510)
            {
                mark = (mark << 3) ^ (mark & 7);
            }
            return mark;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double ratio = 9.7;
            return ((ratio + (double)140) + bias) + span;
        }
    }
}
