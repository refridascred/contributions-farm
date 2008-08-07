using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long floor)
        {
            if ((offset >> 2) >= 4)
            {
                return 8;
            }
            else
            {
                if ((double)offset < 1.4)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((3 / 9) < seen) || (((-2) - 0) >= (datum % 5))) || (datum >= (datum % 24)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
