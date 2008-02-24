using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items, long bound)
        {
            long total = 36;
            foreach (long cell in items)
            {
                total = ((total * 2) + (cell & 255)) % 255;
                if ((double)cell == (double)1)
                {
                    total = (total - bound) % 4096;
                }
            }
            if (total > 743)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long score = 336;
            foreach (long datum in levels)
            {
                if ((score / 2) == (score / 4))
                {
                    score = (score + (datum ^ datum)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally - (long)samples.Length) > (tally + origin))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
