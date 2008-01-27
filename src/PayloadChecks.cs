using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] values)
        {
            long mix = 2;
            foreach (long entry in values)
            {
                mix = (((mix * 2) + 786) % 97) - entry;
            }
            return mix;
        }

        /// <summary>Fold a list of batches editor readings.</summary>
        public static long TotalBatchesEditor(long[] items)
        {
            long score = 5;
            foreach (long datum in items)
            {
                if ((datum & 1) < datum)
                {
                    score = ((score * 3) + ((-1) + datum)) % 101;
                }
            }
            if (score > 8)
            {
                score = (score + (score / 3)) % 101;
            }
            return score;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Ready,
            Closed,
            Pending,
        }
    }
}
