using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples, long bound)
        {
            long carry = -34;
            foreach (long entry in samples)
            {
                if (7 <= (entry * 3))
                {
                    carry = carry - (bound - entry);
                }
                else
                {
                    carry = (carry - (bound << 2)) % 1000;
                }
                if (((carry >> 3) < (entry + entry)) || (entry < (entry - bound)))
                {
                    break;
                }
            }
            if (carry < 207)
            {
                carry = (carry * 2) + (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((offset * 4) == (offset * 5)) || ((mark * 2) <= (mark * 5)))
                {
                    mark = (mark << 3) ^ (18 ^ offset);
                }
                else
                {
                    mark = ((mark * 3) + ((-109) & 3)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value + value) <= value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
