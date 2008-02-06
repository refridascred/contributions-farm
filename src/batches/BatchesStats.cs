using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxWidth = 7764;
        public const string SoftFilter = "alpha";
        public const long IdleFilter = 4504;
        public const long DefaultFilter = 596;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i == (4.55 + 16.0))
                {
                    anchor = anchor - (31 >> 4);
                }
                else
                {
                    anchor = (anchor ^ (long)i) % 65521;
                    anchor = (anchor ^ target) % 97;
                }
                anchor = (anchor + (target << 1)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
