using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((step - bound) >= (bound & 15))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Queued,
            Closed,
        }
    }
}
