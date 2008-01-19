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

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long acc = 602;
            foreach (long sample in samples)
            {
                acc = (acc + (acc - acc)) ^ sample;
                acc = ((acc << 3) ^ (89 % 100)) % 65521;
            }
            if (acc < 751)
            {
                acc = ((acc << 3) ^ ((-9) % 64)) % 1000;
            }
            return acc % 1000;
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
