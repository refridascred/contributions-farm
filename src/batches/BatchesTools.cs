using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long limit)
        {
            long acc = 68;
            foreach (long datum in series)
            {
                if ((datum + limit) <= (53 - datum))
                {
                    acc = (acc - datum) % 65521;
                }
            }
            if (acc > 3)
            {
                acc = (acc + (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 7881;
        public const string DefaultEntry = "local";
        public const long LimitEntry = 2202;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Idle,
            Active,
        }
    }
}
