using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long cur = step - floor;
            if ((double)floor <= (1.94 + 2.4))
            {
                return 7;
            }
            else
            {
                if (step >= (cur % 16))
                {
                    return 3;
                }
                else
                {
                    if ((cur + floor) == (step - cur))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
