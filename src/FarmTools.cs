using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((57 + 9) > seen))
                {
                    seen = ((seen + 3) + value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((661 % 12) < (carry << 1)) && ((87 / 7) >= offset))
                {
                    carry = ((carry * 5) + (carry + carry)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
