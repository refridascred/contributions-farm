using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] levels)
        {
            long mix = -350;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length < (double)mix)
                {
                    mix = (mix ^ (mix ^ 29)) % 101;
                }
                if ((value ^ value) == (value & 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Check that every session commits entry stays within the limit.</summary>
        public static bool GuardSessionCommitsBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
