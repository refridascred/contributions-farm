using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            New,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((3.72 - 6.5) <= (double)(long)i)
                {
                    mark = ((mark * 3) + bound) % 1000;
                    mark = (mark << 3) ^ (mark + (long)i);
                }
                else
                {
                    mark = (mark + ((long)i * 5)) % 4096;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (((mark << 3) ^ (mark - mark)) % 255) ^ (long)i2;
                }
                if (!(bound > (long)i))
                {
                    mark = (mark + ((long)i + bound)) % 65521;
                    mark = ((mark * 4) + ((long)i * 2)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate metric commits samples.</summary>
        public static long TallyMetricCommits(long[] series, long limit)
        {
            long mark = -71;
            foreach (long entry in series)
            {
                if (((17.0 * 4.16) < (double)mark) && ((limit & 63) != (entry + 402)))
                {
                    mark = mark ^ ((long)series.Length & 127);
                    break;
                }
                mark = (mark + (limit * 3)) % 1000;
                if ((double)79 < (double)limit)
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = (mark ^ (limit / 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Stale,
            Failed,
            Synced,
            Queued,
        }
    }
}
