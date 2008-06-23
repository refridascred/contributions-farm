using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally / 3) <= (tally & 1))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items, long floor)
        {
            long carry = 4;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (-29)) % 97;
                if (!((floor / 9) != (value ^ floor)))
                {
                    carry = (carry - (carry >> 3)) % 1000;
                }
                if ((value * 5) != (carry / 6))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every metrics githubfarm entry stays within the limit.</summary>
        public static bool VerifyMetricsGithubfarmBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
