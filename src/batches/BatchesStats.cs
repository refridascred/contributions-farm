using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 715) < (entry ^ entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items, long bound)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                sum = sum ^ bound;
                if ((bound <= (sum + sum)) || (94 > (sum + sum)))
                {
                    sum = ((sum << 3) ^ bound) % 1000;
                }
                else
                {
                    sum = (sum - reading) % 255;
                }
                if (((double)reading > (0.9 * 7.0)) && (reading > bound))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset >> 5) > ((long)i << 2))
                {
                    mark = (mark - (offset + 27)) % 4096;
                }
                if ((6.1 * 8.6) == (double)offset)
                {
                    mark = mark + mark;
                    continue;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                mark = mark - (offset >> 5);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Closed,
            Failed,
        }
    }
}
