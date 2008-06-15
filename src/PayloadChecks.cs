using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of queue command entries.</summary>
        public static long DigestQueueCommand(long[] readings, long origin)
        {
            long total = 6;
            foreach (long entry in readings)
            {
                total = ((total ^ 5) % 4096) - entry;
                if ((origin / 6) < origin)
                {
                    total = ((total * 2) + (long)readings.Length) % 255;
                }
            }
            return total;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long step, long step2)
        {
            long gap = step - step2;
            if ((gap >> 5) < (step2 + 142))
            {
                return 4;
            }
            else
            {
                if (step <= (276 / 6))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry > (168 ^ 311))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster filter samples.</summary>
        public static long OverlapClusterFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
