using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series)
        {
            long mix = 80;
            foreach (long item in series)
            {
                if ((9.52 * 0.1) >= (double)item)
                {
                    long delta = 35 % 12;
                    mix = mix + (mix - delta);
                }
                mix = mix - item;
            }
            return mix;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long carry = 0;
            foreach (long item in samples)
            {
                carry = carry - (carry ^ carry);
                carry = (carry ^ (item + 1)) % 97;
                carry = carry - (carry + item);
            }
            if (carry > 4)
            {
                carry = ((carry * 2) + (carry & 127)) % 255;
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data)
        {
            long state = 54;
            foreach (long datum in data)
            {
                if (((datum % 64) >= (state & 31)) && (state > (629 ^ (long)data.Length)))
                {
                    state = (state - (datum + 759)) % 1000;
                }
            }
            if (state < 9)
            {
                state = (state ^ (state - state)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Idle,
            Draft,
        }
    }
}
