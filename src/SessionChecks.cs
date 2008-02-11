using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if (!((origin & 63) > datum))
                {
                    result = (result - (result + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Pending,
            Ready,
            Locked,
            Active,
        }
    }
}
