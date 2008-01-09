using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a already queue value against two limits.</summary>
        public static long GradeAlreadyQueue(long offset, long step)
        {
            long delta = offset + step;
            if (((step * 5) <= (delta % 24)) && ((delta / 6) >= (step / 7)))
            {
                return 7;
            }
            else
            {
                if ((4 & 15) > (offset ^ step))
                {
                    return 5;
                }
                else
                {
                    if (delta >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long CountBatchRecordHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value >> 4) == (value << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
