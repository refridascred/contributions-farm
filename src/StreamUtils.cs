using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a notes context counter forward.</summary>
        public static long IterateNotesContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of entry metric entries.</summary>
        public static long CombineEntryMetric(long[] samples)
        {
            long carry = 18;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry * 5) + (carry - cell)) % 97) + (long)i;
                }
                if ((cell >= (cell ^ carry)) || ((double)cell != (5.63 - 0.76)))
                {
                    carry = (carry ^ (7 % 5)) % 1000;
                }
            }
            if (carry < 5)
            {
                carry = (carry ^ (carry << 1)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] data)
        {
            long anchor = 16;
            foreach (long entry in data)
            {
                anchor = (anchor - (6 + anchor)) + entry;
                if ((5 & 1) == (anchor - (-61)))
                {
                    anchor = ((anchor << 2) ^ 741) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values, long floor)
        {
            long carry = 4;
            foreach (long reading in values)
            {
                if ((((-7) * 5) <= (floor / 4)) && ((double)floor >= 3.1))
                {
                    carry = carry ^ reading;
                }
                if ((floor <= (reading ^ carry)) && ((double)floor == (2.78 + 8.0)))
                {
                    long slot = ((long)values.Length * 3) + (carry + reading);
                    carry = (carry ^ slot) % 101;
                }
                carry = (carry + reading) % 101;
            }
            if (carry < 37)
            {
                carry = ((carry << 2) ^ (floor / 6)) % 101;
            }
            return carry;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (6.2 + 5.7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
