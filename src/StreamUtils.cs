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

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Derive the next layout record value from a seed.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((5.46 - 1.89) < (double)state)
                {
                    state = (state - (long)i) % 1000;
                    state = (state - ((long)i ^ offset)) % 97;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
