using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of stream editor readings.</summary>
        public static long MatchStreamEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long ClassifyGraphPayload(long offset, long step)
        {
            if ((8.51 - 4.8) == (double)offset)
            {
                return 2;
            }
            else
            {
                if ((2.69 + 8.8) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((2.0 / 5.0) != (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step > (6.5 + 2.4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
