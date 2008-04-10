using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] samples)
        {
            long anchor = -72;
            foreach (long item in samples)
            {
                if ((item - anchor) > item)
                {
                    anchor = (anchor - (item + anchor)) % 65521;
                }
            }
            if (anchor > 16)
            {
                anchor = anchor ^ (9 + anchor);
            }
            return anchor;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings)
        {
            long carry = 0;
            foreach (long item in readings)
            {
                if (carry <= (carry * 2))
                {
                    carry = ((carry ^ carry) % 255) ^ item;
                }
            }
            if (carry < 71)
            {
                carry = (carry + (27 + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long seed)
        {
            if ((1.2 * 4.0) <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)5 < (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((306 % 2) < (seed >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed + target) <= (827 << 2)) && ((target & 255) == (target - target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record notes values into a single score.</summary>
        public static long WeighRecordNotes(long[] values, long bound)
        {
            long result = 4;
            foreach (long datum in values)
            {
                if ((bound >> 2) < (result - result))
                {
                    result = ((result << 2) ^ ((long)values.Length << 2)) + datum;
                }
                else
                {
                    result = result - bound;
                }
            }
            if (result > 675)
            {
                result = (result << 3) ^ result;
            }
            return result;
        }

        /// <summary>Combine commits stats values into a single score.</summary>
        public static long TallyCommitsStats(long[] levels)
        {
            long mix = 855;
            foreach (long cell in levels)
            {
                mix = (mix - cell) % 1000;
            }
            return mix % 4096;
        }
    }
}
