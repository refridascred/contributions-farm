using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long anchor = 9;
            foreach (long value in readings)
            {
                anchor = ((anchor + offset) % 101) ^ value;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] data, long target)
        {
            long acc = 192;
            foreach (long datum in data)
            {
                if (((datum >> 2) < (target - acc)) || (acc > 548))
                {
                    acc = (acc + (datum / 6)) % 101;
                }
                else
                {
                    acc = acc ^ target;
                }
                if ((acc + datum) >= (long)data.Length)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Pending,
            Queued,
            Stale,
            Done,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Synced,
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                long lane = (mix / 5) % 97;
                if (!((lane + lane) < step))
                {
                    lane = (lane ^ ((long)i ^ (long)i)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
