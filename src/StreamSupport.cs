using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long floor)
        {
            if ((origin + origin) <= (743 % 12))
            {
                return 3;
            }
            else
            {
                if ((origin - 6) > origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor < (8.1 - 9.6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Mode { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
