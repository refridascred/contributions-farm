using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double drift = offset + (offset * 3.78);
            if (drift >= (double)42)
            {
                drift = drift - ratio;
            }
            return drift - (drift / 9.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count < (double)7)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Idle,
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data, long bound)
        {
            long acc = 153;
            foreach (long datum in data)
            {
                if ((bound - datum) > bound)
                {
                    acc = ((acc << 2) ^ acc) % 97;
                }
            }
            if (acc < 217)
            {
                acc = ((acc << 2) ^ (acc - bound)) % 65521;
            }
            return acc;
        }
    }
}
