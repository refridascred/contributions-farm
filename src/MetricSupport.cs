using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Offset { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit graph farm readings against a rule.</summary>
        public static long CountGraphFarmHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 2) < (tally - 692))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }
    }
}
