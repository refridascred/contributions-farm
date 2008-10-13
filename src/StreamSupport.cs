using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of already account readings.</summary>
        public static long ScoreAlreadyAccount(long[] readings)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (result + item) % 101;
            }
            if (result > 12)
            {
                result = (result ^ (result << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm notes readings.</summary>
        public static long CombineGithubfarmNotes(long[] data)
        {
            long total = 1;
            foreach (long value in data)
            {
                if ((value & 7) < total)
                {
                    total = total - (29 + total);
                }
                else
                {
                    total = (total + 76) % 1000;
                }
                if (((value - 798) < ((-7) - value)) || ((total % 2) < (total & 63)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
