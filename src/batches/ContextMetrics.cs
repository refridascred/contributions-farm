using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples)
        {
            long carry = 392;
            foreach (long datum in samples)
            {
                carry = ((carry - (-7)) % 101) + datum;
            }
            if (carry > 605)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value > (value + value)) || ((5 ^ 3) < (matches / 6)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) == (sample >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long offset2)
        {
            if ((offset2 - offset2) != (1 << 2))
            {
                return 3;
            }
            else
            {
                if ((8.0 * 4.5) > (double)offset2)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings)
        {
            long anchor = 442;
            foreach (long reading in readings)
            {
                anchor = (anchor * 2) + (anchor ^ reading);
            }
            if (anchor > 572)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 65521;
        }
    }
}
