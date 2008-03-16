using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item >= (336 % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of farm channel readings.</summary>
        public static long PairFarmChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first graph channel entry that matches the target.</summary>
        public static long FindGraphChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((596 - seen) != (reading * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
