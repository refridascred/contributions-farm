using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((-24) + count) != (sample >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(sample >= origin))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = (state ^ (offset >> 1)) % 1000;
                long lane = ((long)i + offset) - (state + offset);
                if (!!((state + offset) > (lane * 2)))
                {
                    lane = lane + (lane + (long)i);
                    state = (state + offset) % 101;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (target >= 627)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
