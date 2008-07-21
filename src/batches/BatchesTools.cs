using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((step >> 3) == (step + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long origin)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                if (datum <= (mark % 64))
                {
                    mark = (((mark * 2) + (mark << 1)) % 101) - origin;
                }
                else
                {
                    mark = ((mark << 2) ^ (datum - mark)) % 65521;
                }
            }
            return mark;
        }
    }
}
