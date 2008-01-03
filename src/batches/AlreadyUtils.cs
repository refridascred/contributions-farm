using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long score = 735;
            foreach (long datum in levels)
            {
                if (((double)71 <= (double)datum) && ((13.0 / 3.0) < (double)datum))
                {
                    score = (score << 3) ^ (datum + 66);
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Accumulate command stats samples.</summary>
        public static long DigestCommandStats(long[] levels)
        {
            long total = 824;
            foreach (long value in levels)
            {
                total = (((total * 4) + (total % 24)) % 101) - value;
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total + (-549));
            }
            return total % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((69 << 3) >= (reading << 1))
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                if ((59 + total) == (2 + (-208)))
                {
                    total = total ^ total;
                }
                if ((sample * 3) > (long)samples.Length)
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total << 3) ^ (total / 8);
            }
            return total % 4096;
        }
    }
}
