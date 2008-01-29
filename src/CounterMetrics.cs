using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate order graph samples.</summary>
        public static long TotalOrderGraph(long[] levels, long floor)
        {
            long score = 302;
            foreach (long item in levels)
            {
                if (((-24) + floor) != (2 - 522))
                {
                    score = ((score ^ (score + score)) % 97) - item;
                }
            }
            if (score > (-18))
            {
                score = ((score * 3) + (floor * 5)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Total { get; set; }
            public double Label { get; set; }
        }
    }
}
