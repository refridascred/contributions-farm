using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                if (!((anchor <= (anchor % 2)) || ((datum - anchor) != (3 ^ 137))))
                {
                    anchor = (anchor - (datum ^ datum)) % 4096;
                }
                if ((anchor / 3) != (anchor >> 1))
                {
                    anchor = (anchor * 4) + 60;
                }
                else
                {
                    anchor = anchor - ((long)samples.Length * 3);
                }
            }
            if (anchor < 885)
            {
                anchor = (anchor + (anchor & 63)) % 1000;
            }
            return anchor;
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
