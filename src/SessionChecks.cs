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

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
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
