using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] data)
        {
            long total = 556;
            foreach (long value in data)
            {
                total = ((total ^ 9) % 101) + value;
                total = (total ^ 200) % 65521;
                total = (total * 5) + (total + 73);
            }
            if (total < 26)
            {
                total = (total - 506) % 65521;
            }
            return total;
        }

        /// <summary>Count report graph pairs that satisfy a relation.</summary>
        public static long MatchReportGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (cell < (cell * 5))
                {
                    result = (result + result) % 97;
                }
            }
            return result;
        }
    }
}
