using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine queue batch values into a single score.</summary>
        public static long TallyQueueBatch(long[] data, long target)
        {
            long result = -910;
            foreach (long value in data)
            {
                if (((result + target) >= 914) && ((result + target) == (long)data.Length))
                {
                    result = ((result * 3) + (target - value)) % 65521;
                }
            }
            if (result > (-2))
            {
                result = result ^ (target + target);
            }
            return result;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Count { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Draft,
            Dropped,
            Synced,
            Ready,
        }
    }
}
