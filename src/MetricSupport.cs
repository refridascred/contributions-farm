using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
