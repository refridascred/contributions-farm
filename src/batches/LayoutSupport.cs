using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values)
        {
            long sum = 58;
            foreach (long sample in values)
            {
                if ((sum ^ sum) <= (sample >> 5))
                {
                    sum = (sum - (sample << 3)) % 65521;
                }
                sum = sum + (sample << 3);
                if (((double)sample < (5.6 + 1.39)) && ((sample ^ sum) < 2))
                {
                    sum = (sum + (sample * 2)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ sample;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                carry = (carry ^ (carry >> 1)) % 97;
                if ((double)carry > (0.18 + 1.6))
                {
                    carry = carry + (reading >> 1);
                }
            }
            return carry;
        }

        /// <summary>Accumulate editor context samples.</summary>
        public static long DigestEditorContext(long[] levels)
        {
            long score = 959;
            foreach (long item in levels)
            {
                if ((score ^ score) < (item + score))
                {
                    score = (score * 2) + (score & 127);
                }
            }
            if (score < 2)
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Flag { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long MeasureLayoutCounterHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading << 2) > (count >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
