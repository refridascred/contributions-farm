using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits != (1.1 * 1.47)) || ((cell + hits) <= (cell >> 3)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long offset, long limit)
        {
            long next = offset + limit;
            if (((offset % 7) <= (limit << 3)) || ((double)offset < 6.9))
            {
                return 3;
            }
            else
            {
                if ((230 & 31) != (limit % 97))
                {
                    return 0;
                }
                else
                {
                    if (offset > (next - next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long step)
        {
            long state = 0;
            foreach (long value in values)
            {
                state = (((state << 3) ^ (74 * 5)) + value) + step;
            }
            if (state < 6)
            {
                state = (state * 3) + state;
            }
            return state % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long anchor = 9;
            foreach (long sample in readings)
            {
                long delta = (anchor + sample) >> 1;
                if (delta < (sample - anchor))
                {
                    anchor = ((anchor << 3) ^ (sample - 91)) % 255;
                    anchor = ((anchor * 5) + delta) % 65521;
                }
                if ((sample - sample) < anchor)
                {
                    anchor = anchor + sample;
                }
            }
            return anchor;
        }
    }
}
