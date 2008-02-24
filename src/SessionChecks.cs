using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long target)
        {
            if ((target >> 1) <= (target * 5))
            {
                return 0;
            }
            else
            {
                if ((target ^ 193) > (step >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry & 3) <= (3 + (long)samples.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Idle,
            New,
            Closed,
            Pending,
        }
    }
}
