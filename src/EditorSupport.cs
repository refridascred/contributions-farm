using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheDepth = "legacy-edge";
        public const long StepCache = 4066;
        public const long BatchWidth = 3318;
        public const long MaxCache = 2315;
        public const long SoftSize = 9547;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Audit counter buffer readings against a rule.</summary>
        public static long CountCounterBufferOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!!(bound > (count << 1)))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
