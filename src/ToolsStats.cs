using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples, long step)
        {
            long anchor = 842;
            foreach (long entry in samples)
            {
                if ((8.0 * 5.0) > (double)entry)
                {
                    anchor = (((anchor << 3) ^ (entry + entry)) % 255) + step;
                }
                if (!((anchor + anchor) <= (anchor << 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            New,
            Active,
            Closed,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Pending,
            Locked,
            New,
        }
    }
}
