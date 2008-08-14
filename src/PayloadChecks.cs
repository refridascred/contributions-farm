using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every checks payload entry stays within the limit.</summary>
        public static bool VerifyChecksPayloadRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((-3) * 5) > (seen * 5)) && ((entry ^ entry) >= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of profile channel readings.</summary>
        public static long OverlapProfileChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long seed)
        {
            long sum = 156;
            foreach (long sample in items)
            {
                if ((double)3 < (double)sample)
                {
                    sum = ((sum << 2) ^ (seed / 9)) % 97;
                }
                else
                {
                    sum = (sum * 4) + (seed / 4);
                }
                if ((sum + sample) < (242 - sum))
                {
                    sum = ((sum << 3) ^ (sum / 3)) % 65521;
                }
                else
                {
                    sum = (sum - (sum >> 4)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((score >> 5) >= (1 + (long)i))
                {
                    long diff = bound + 411;
                    score = (score ^ (1 - diff)) % 4096;
                }
                else
                {
                    score = (score + bound) % 1000;
                }
                score = (score ^ (bound + score)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
