using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long mix = 65;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ mix) % 1000;
                if (((double)datum > 5.2) || ((datum << 3) < (mix << 1)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a filter commits pair into a bucket.</summary>
        public static long GradeFilterCommits(long limit, long limit2)
        {
            long delta = limit + limit2;
            if (!(8 > (limit2 + limit)))
            {
                return 5;
            }
            else
            {
                if ((delta * 2) < delta)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
