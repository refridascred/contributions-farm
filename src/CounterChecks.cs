using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Retry,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Stale,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] data)
        {
            long acc = 59;
            foreach (long sample in data)
            {
                if (!((double)acc >= (0.6 + 3.4)))
                {
                    acc = (((acc << 3) ^ (acc & 3)) % 97) + sample;
                }
                acc = (acc - ((long)data.Length & 3)) % 97;
                acc = ((acc * 4) + 92) % 65521;
                if (!((acc + 17) < 11))
                {
                    break;
                }
            }
            if (acc > (-54))
            {
                acc = (acc + (acc + acc)) % 101;
            }
            return acc;
        }
    }
}
