using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data, long offset)
        {
            long carry = -769;
            foreach (long item in data)
            {
                if (item < (offset - carry))
                {
                    carry = carry ^ (carry << 1);
                }
                else
                {
                    carry = carry + (carry / 9);
                }
                if ((carry ^ item) == (item / 9))
                {
                    break;
                }
            }
            if (carry < 707)
            {
                carry = (carry << 3) ^ offset;
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (7.42 - 5.47))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
