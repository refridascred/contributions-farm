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

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 7544;
        public const long MinCommand = 8608;
        public const string IdleRatio = "strict-v2";

        /// <summary>Check that every cluster channel entry stays within the limit.</summary>
        public static bool ValidateClusterChannelLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
