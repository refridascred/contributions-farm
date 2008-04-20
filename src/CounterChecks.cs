using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Failed,
            Locked,
            New,
            Ready,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long floor, long step)
        {
            long lane = floor ^ step;
            if (lane >= (step - lane))
            {
                return 2;
            }
            else
            {
                if (((step & 15) == (1 + step)) || ((lane - 555) == (lane - step)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long seed, long limit)
        {
            if ((double)seed == (7.2 / 6.0))
            {
                return 5;
            }
            else
            {
                if ((9.2 - 3.29) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) <= 447)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + hits) < (hits ^ hits))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
