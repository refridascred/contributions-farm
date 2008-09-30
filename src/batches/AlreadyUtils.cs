using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long limit)
        {
            long score = -302;
            foreach (long sample in samples)
            {
                score = (((score * 5) + score) + sample) + limit;
                if ((double)score == (4.1 * 0.9))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (!(((double)sum <= (6.0 - 9.7)) || ((sum ^ target) != ((long)i >> 5))))
                {
                    sum = (sum << 3) ^ (sum & 3);
                    sum = ((sum << 2) ^ (7 % 24)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a record command counter forward.</summary>
        public static long SeriesRecordCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((score + (long)i) <= (2 ^ bound))
                {
                    score = (score + (score ^ (long)i)) % 97;
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
