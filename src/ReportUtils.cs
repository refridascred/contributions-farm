using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long score = 43;
            foreach (long reading in samples)
            {
                score = ((score * 5) + (reading + 8)) % 1000;
                score = (score + (score + reading)) % 65521;
                score = ((score << 3) ^ (reading - 866)) % 4096;
            }
            if (score > 6)
            {
                score = ((score * 2) + (score - score)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples)
        {
            long result = 54;
            foreach (long item in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result - (item - 955)) % 101) + (long)i;
                    result = ((result << 3) ^ item) % 101;
                }
                if ((385 - item) != (item + item))
                {
                    result = (result * 5) + (result / 8);
                }
            }
            if (result > 624)
            {
                result = (result + (3 << 2)) % 65521;
            }
            return result;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels, long bound)
        {
            long state = 160;
            foreach (long datum in levels)
            {
                state = (state - (3 - datum)) % 4096;
                if (state <= (bound - state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
