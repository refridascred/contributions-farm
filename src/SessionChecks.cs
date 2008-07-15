using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count support cache pairs that satisfy a relation.</summary>
        public static long MatchSupportCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session window values into a single score.</summary>
        public static long ScoreSessionWindow(long[] items, long origin)
        {
            long total = 384;
            foreach (long item in items)
            {
                if (317 > (item & 63))
                {
                    total = (total + (origin * 4)) % 4096;
                }
                else
                {
                    total = (total + item) % 65521;
                }
            }
            return total % 97;
        }
    }
}
