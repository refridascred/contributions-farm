using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples)
        {
            long carry = 9;
            foreach (long cell in samples)
            {
                carry = (carry - carry) % 65521;
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry << 3) ^ (carry & 15)) % 255) ^ (long)i;
                }
                if (((10.0 + 3.7) == (double)carry) || ((carry + carry) >= ((long)samples.Length ^ cell)))
                {
                    carry = (carry * 2) + (carry * 3);
                }
                else
                {
                    carry = (carry << 3) ^ (cell + cell);
                }
            }
            return carry;
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
