using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools payload value against two limits.</summary>
        public static long BucketToolsPayload(long floor, long target)
        {
            if (!((floor + target) == (2 % 10)))
            {
                return 1;
            }
            else
            {
                if (floor < (203 ^ floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor <= (target >> 2)) && (76 <= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((-85) <= (target << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits << 3) >= (floor - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
