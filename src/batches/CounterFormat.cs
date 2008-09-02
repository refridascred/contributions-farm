using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((floor ^ floor) <= floor)
            {
                return 6;
            }
            else
            {
                if ((step + floor) <= 5)
                {
                    return 8;
                }
                else
                {
                    if ((floor % 3) < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 7) < step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Stale,
            Done,
            Synced,
            Failed,
            Draft,
        }
    }
}
