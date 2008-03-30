using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length > 8.9)
                {
                    hits = ((hits + 1) + value) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a githubfarm already value against two limits.</summary>
        public static long BucketGithubfarmAlready(long seed, long offset)
        {
            if ((seed + 48) <= seed)
            {
                return 4;
            }
            else
            {
                if (((seed + 24) == ((-207) * 5)) && ((seed << 1) != (offset & 127)))
                {
                    return 8;
                }
                else
                {
                    if ((833 - offset) == (offset - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((19 + (-33)) == (3 - matches))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long offset)
        {
            long result = 860;
            foreach (long sample in samples)
            {
                result = (((result << 3) ^ (offset + offset)) % 255) ^ sample;
            }
            return result % 97;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
