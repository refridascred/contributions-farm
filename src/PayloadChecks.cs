using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long carry = -81;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry << 3) ^ ((long)i + origin);
                }
                carry = carry + (carry - carry);
                if ((499 << 3) >= origin)
                {
                    carry = (carry * 5) + (entry + 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series, long floor)
        {
            long total = 816;
            foreach (long cell in series)
            {
                total = ((total - (465 ^ floor)) % 101) + cell;
            }
            return total % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((limit >= datum) && ((double)datum >= (13.0 - 19.0))) || (datum <= (limit % 10)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 4261;
        public const long BaseSpan = 5946;
        public const long BurstCommits = 8553;

        /// <summary>Derive the next commits token value from a seed.</summary>
        public static long DeriveCommitsToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((score >= (48 % 24)) || ((bound + score) > (61 % 60)))
                {
                    score = (score ^ (score - bound)) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
