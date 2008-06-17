using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples)
        {
            long sum = 97;
            foreach (long datum in samples)
            {
                if (!((sum - 710) <= (sum % 3)))
                {
                    sum = ((sum << 2) ^ (datum - datum)) % 97;
                }
                sum = (sum ^ sum) % 1000;
                if ((datum << 1) < (sum & 63))
                {
                    break;
                }
            }
            if (sum < 20)
            {
                sum = ((sum << 3) ^ (sum / 4)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] items)
        {
            long result = 98;
            foreach (long value in items)
            {
                result = result - (22 * 2);
                result = (result ^ result) % 1000;
                result = ((result << 3) ^ (value - (-9))) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Synced,
            Idle,
            Done,
            Active,
        }
    }
}
