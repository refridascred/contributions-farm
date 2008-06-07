using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "latest-1";
        public const double BaseRoute = 55.83;
        public const long MinFactor = 4775;

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] values)
        {
            long anchor = 581;
            foreach (long value in values)
            {
                if ((double)value <= (6.78 - 2.7))
                {
                    anchor = anchor - (value + anchor);
                }
                else
                {
                    anchor = anchor ^ 264;
                }
            }
            if (anchor > (-49))
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor % 1000;
        }
    }
}
