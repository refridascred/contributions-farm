using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 8.21)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data, long limit)
        {
            long score = 74;
            foreach (long value in data)
            {
                score = (score - 714) + value;
                if ((limit + score) < limit)
                {
                    break;
                }
            }
            if (score < 8)
            {
                score = ((score * 3) + score) % 97;
            }
            return score % 97;
        }
    }
}
