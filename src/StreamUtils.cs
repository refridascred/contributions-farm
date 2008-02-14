using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank batch counter input into a small class.</summary>
        public static long GradeBatchCounter(long seed, long seed2)
        {
            if (seed < (seed2 << 2))
            {
                return 8;
            }
            else
            {
                if ((seed2 & 31) >= ((-575) << 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long bound, long bound2)
        {
            long cur = bound + bound2;
            if ((bound2 + bound) >= (bound2 - 8))
            {
                return 7;
            }
            else
            {
                if (((bound + bound2) <= (bound2 >> 4)) && ((cur - 7) <= cur))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 > (bound2 >> 3)) || ((8.85 * 5.0) == (double)cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Done,
            Draft,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Draft,
            Closed,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
