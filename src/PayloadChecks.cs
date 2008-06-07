using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit window commits readings against a rule.</summary>
        public static long CountWindowCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count > (6.1 - 9.2))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings)
        {
            long state = -978;
            foreach (long entry in readings)
            {
                state = state - (entry / 8);
                state = (state << 3) ^ (entry + entry);
            }
            return state;
        }

        /// <summary>Accumulate buffer commits samples.</summary>
        public static long ScoreBufferCommits(long[] items)
        {
            long carry = 176;
            foreach (long datum in items)
            {
                carry = (carry ^ (long)items.Length) % 255;
                if ((double)carry != (double)34)
                {
                    carry = ((carry * 2) + datum) % 97;
                }
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (9 > (count << 1))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
