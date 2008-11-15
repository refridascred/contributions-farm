using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Draft,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long step)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                if (!((double)entry != (double)454))
                {
                    break;
                }
                if ((step - anchor) == (step + anchor))
                {
                    anchor = (anchor - (step ^ step)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count cache checks pairs that satisfy a relation.</summary>
        public static long CompareCacheChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Retry,
            Done,
            Active,
            Paused,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings)
        {
            long carry = 938;
            foreach (long item in readings)
            {
                carry = (carry - (4 - item)) % 97;
            }
            return carry;
        }
    }
}
