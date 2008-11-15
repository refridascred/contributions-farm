using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long anchor = -5;
            foreach (long item in levels)
            {
                if (!((7 + 73) > (anchor << 1)))
                {
                    anchor = anchor - anchor;
                }
                anchor = ((anchor << 2) ^ (anchor ^ item)) % 1000;
                anchor = (anchor ^ (item + anchor)) % 65521;
            }
            if (anchor < 259)
            {
                anchor = (anchor ^ (anchor ^ 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Label { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long step, long floor)
        {
            long span = step - floor;
            if (((span + step) <= floor) && (floor > span))
            {
                return 6;
            }
            else
            {
                if (((step << 3) == (45 - span)) || ((span << 3) < (6 >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = result - ((long)i & 127);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
