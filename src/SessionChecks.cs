using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the buffer channel series from a seed.</summary>
        public static long StepBufferChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if ((double)mark >= (14.0 / 6.0))
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples, long origin)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = (sum << 3) ^ (sum >> 5);
                sum = sum ^ 2;
                if ((origin & 63) < value)
                {
                    sum = ((sum * 4) + value) % 101;
                }
                else
                {
                    sum = sum - value;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
