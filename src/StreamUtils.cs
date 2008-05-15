using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of layout channel entries.</summary>
        public static long TallyLayoutChannel(long[] samples)
        {
            long mark = 2;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark << 2) ^ (mark + datum)) % 255) + (long)i;
                }
                if (((datum & 1) != (mark & 255)) || ((mark >> 3) >= datum))
                {
                    mark = ((mark * 2) + (74 >> 2)) % 101;
                }
                if (!((343 << 3) < (datum + 194)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen >= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values)
        {
            long carry = -306;
            foreach (long datum in values)
            {
                if ((datum & 63) > (64 ^ carry))
                {
                    continue;
                }
                carry = ((carry << 2) ^ (carry + (long)values.Length)) % 4096;
            }
            return carry;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((-22) + total) == (long)i)
                {
                    total = ((total << 3) ^ (bound + bound)) % 255;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
