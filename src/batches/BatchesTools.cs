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

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Idle,
            Active,
        }
    }
}
