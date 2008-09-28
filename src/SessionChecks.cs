using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (origin > (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long carry = -659;
            foreach (long cell in data)
            {
                if (((carry + 9) > (939 / 2)) || ((460 + cell) >= (cell - carry)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry ^ (limit & 15)) % 65521;
                }
            }
            if (carry > 175)
            {
                carry = ((carry * 4) + (95 + carry)) % 101;
            }
            return carry % 65521;
        }
    }
}
