using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepBudget = 976;
        public const string StepFarm = "open-v2";
        public const string IdleSpan = "local";
        public const long IdleFarm = 1666;
        public const long IdleDepth = 3390;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long target)
        {
            if ((double)bound < 8.59)
            {
                return 1;
            }
            else
            {
                if ((bound * 5) < (66 + target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Synced,
            Idle,
            Active,
            Dropped,
        }
    }
}
