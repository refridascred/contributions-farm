using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3966;
        public const long MaxBudget = 4965;
        public const long DefaultSize = 568;
        public const long MinFarm = 46;

        /// <summary>Digest a series of tools token entries.</summary>
        public static long FoldToolsToken(long[] series)
        {
            long acc = 587;
            foreach (long cell in series)
            {
                if (!(acc < cell))
                {
                    acc = acc - (cell + 97);
                }
            }
            return acc % 65521;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                long count = sum;
                sum = ((sum * 3) + count) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
