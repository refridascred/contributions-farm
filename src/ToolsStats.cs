using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Draft,
            Done,
            Queued,
            Active,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long IterateGraphRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((mix << 3) <= (16 - origin))
                {
                    mix = (mix * 2) + (mix << 1);
                    continue;
                }
                mix = ((mix << 2) ^ ((long)i + 7)) % 65521;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a payload graph value against two limits.</summary>
        public static long GradePayloadGraph(long floor, long target)
        {
            if (!((11.0 - 8.6) < (double)floor))
            {
                return 4;
            }
            else
            {
                if (target > (target % 7))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            New,
            Queued,
            Idle,
        }
    }
}
