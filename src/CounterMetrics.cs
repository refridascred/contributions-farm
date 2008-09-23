using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine stream layout values into a single score.</summary>
        public static long DigestStreamLayout(long[] series)
        {
            long result = 959;
            foreach (long entry in series)
            {
                if (result > (9 / 9))
                {
                    result = (result + (result ^ 109)) ^ entry;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Failed,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor + (floor ^ (long)i2)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
