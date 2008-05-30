using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Digest a series of filter payload entries.</summary>
        public static long TotalFilterPayload(long[] values, long step)
        {
            long state = 61;
            foreach (long item in values)
            {
                if (item >= (step + item))
                {
                    state = state - (state + item);
                }
            }
            if (state > 4)
            {
                state = ((state * 3) + 324) % 65521;
            }
            return state;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                long gap = (long)i;
                result = (result + (result ^ gap)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
