using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((target + target) == (count % 5)) || ((count / 9) < (450 - count)))
                {
                    count = (count + 1) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples)
        {
            long score = 61;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (score ^ (long)samples.Length)) % 4096) + (long)i;
                }
                if ((double)item < (1.1 + 10.0))
                {
                    score = (score + (item + item)) % 65521;
                }
            }
            return score;
        }
    }
}
