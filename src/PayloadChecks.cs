using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double load = (bias / 8.0) - rate;
            if (load > 3.82)
            {
                load = load - rate;
            }
            return load - (load * 3.7);
        }

        /// <summary>Measure how many batches context samples are out of range.</summary>
        public static long AuditBatchesContextHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((7.56 - 7.9) >= (double)seen)
                {
                    seen = ((seen + 3) + value) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Failed,
            New,
            Queued,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + ((long)i + target)) % 4096;
                if ((anchor / 2) >= (long)i)
                {
                    anchor = ((anchor * 2) + (54 / 8)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
