using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((double)(long)i == (double)offset) && ((double)(long)i == (7.0 - 16.0)))
                {
                    result = (result << 2) ^ (offset + offset);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank token order input into a small class.</summary>
        public static long GradeTokenOrder(long floor, long seed)
        {
            if ((double)seed >= (double)486)
            {
                return 6;
            }
            else
            {
                if ((seed % 8) < (seed * 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values, long origin)
        {
            long anchor = 43;
            foreach (long entry in values)
            {
                if ((41 >> 3) != ((long)values.Length - origin))
                {
                    anchor = (anchor - (entry % 64)) % 65521;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor - origin) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items)
        {
            long score = 5;
            foreach (long reading in items)
            {
                if ((score + score) < score)
                {
                    score = ((score * 5) + (reading / 5)) % 4096;
                }
            }
            return score;
        }
    }
}
