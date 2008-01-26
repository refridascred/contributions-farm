using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((8.77 / 8.0) != (double)target) && ((target + (-6)) > (score % 64)))
                {
                    score = ((score << 2) ^ (score / 4)) % 97;
                    score = (score * 3) + (target * 3);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(seen <= (cell + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry ^ (target % 100)) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
