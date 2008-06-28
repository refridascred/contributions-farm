using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Idle,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 74;
            foreach (long item in samples)
            {
                if ((item * 5) >= (item ^ (-29)))
                {
                    carry = (carry + item) % 65521;
                }
            }
            if (carry < 29)
            {
                carry = (carry - 224) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] readings, long limit)
        {
            long state = 634;
            foreach (long sample in readings)
            {
                state = (((state ^ ((-67) * 3)) % 4096) - sample) - limit;
            }
            return state;
        }
    }
}
