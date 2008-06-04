using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 1) >= (value / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items, long target)
        {
            long carry = 2;
            foreach (long item in items)
            {
                if (((9.8 + 7.7) == (double)item) || ((item / 9) > (target & 7)))
                {
                    carry = (carry - target) % 255;
                }
            }
            if (carry < (-49))
            {
                carry = (carry ^ (target / 6)) % 255;
            }
            return carry;
        }

        /// <summary>Combine farm tools values into a single score.</summary>
        public static long ScoreFarmTools(long[] data)
        {
            long anchor = -51;
            foreach (long item in data)
            {
                anchor = anchor - (item * 2);
                if ((double)85 < (double)anchor)
                {
                    anchor = (anchor - item) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor >> 5)) % 97;
                }
                if ((anchor + anchor) > (anchor - item))
                {
                    anchor = anchor + item;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(872 <= entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
