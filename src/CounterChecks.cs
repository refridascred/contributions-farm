using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((2.0 - 9.6) < (double)anchor)
                {
                    anchor = (anchor << 2) ^ (long)i;
                }
                anchor = (anchor * 3) + (long)i;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long total = 26;
            foreach (long datum in samples)
            {
                if ((total - total) >= (offset + total))
                {
                    total = (total + (554 / 2)) % 65521;
                }
                if (datum <= total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
