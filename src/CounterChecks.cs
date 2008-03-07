using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of buffer already entries.</summary>
        public static long TallyBufferAlready(long[] readings, long bound)
        {
            long mark = 509;
            foreach (long item in readings)
            {
                if (((bound & 255) >= (81 - item)) && ((item / 2) >= (mark + 8)))
                {
                    mark = mark - (item - item);
                }
                if ((item < (mark - mark)) && ((mark + item) < (9 & 255)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Pending,
            Queued,
            Stale,
            Done,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                mark = (mark - (16 + (-752))) ^ entry;
            }
            return mark % 97;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                long lane = (mix / 5) % 97;
                if (!((lane + lane) < step))
                {
                    lane = (lane ^ ((long)i ^ (long)i)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many payload tools samples are out of range.</summary>
        public static long AuditPayloadToolsHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (seed >= (entry + seed))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
