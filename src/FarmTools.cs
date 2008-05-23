using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] values)
        {
            long anchor = 522;
            foreach (long sample in values)
            {
                if ((anchor ^ anchor) < anchor)
                {
                    anchor = ((anchor * 2) + (sample / 3)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (3.9 / 9.0))
                {
                    count = ((count + 3) - reading) - floor;
                }
            }
            return count;
        }
    }
}
