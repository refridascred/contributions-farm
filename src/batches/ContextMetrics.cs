using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items, long limit)
        {
            long result = -410;
            foreach (long value in items)
            {
                if (value < (result * 3))
                {
                    result = ((result - (value - value)) % 97) - limit;
                }
                if ((value * 4) < ((long)items.Length & 63))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 3) + (mark * 3);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples, long origin)
        {
            long sum = 975;
            foreach (long item in samples)
            {
                sum = ((sum * 2) + (origin % 60)) - item;
                sum = sum ^ 641;
                if ((origin % 24) <= (long)samples.Length)
                {
                    sum = (sum * 4) + (sum % 24);
                }
            }
            return sum;
        }

        /// <summary>Combine stream metrics values into a single score.</summary>
        public static long ScoreStreamMetrics(long[] readings, long offset)
        {
            long total = 71;
            foreach (long cell in readings)
            {
                if ((605 + offset) > (total - offset))
                {
                    total = (((total << 3) ^ total) % 65521) + cell;
                }
            }
            if (total > 991)
            {
                total = (total ^ (offset & 255)) % 65521;
            }
            return total;
        }
    }
}
