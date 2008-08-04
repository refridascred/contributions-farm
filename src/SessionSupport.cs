using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((4.0 + 8.0) == (double)count) || ((datum - count) <= (76 - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long bound)
        {
            long result = 97;
            foreach (long cell in levels)
            {
                result = result ^ (bound + result);
                if ((9.43 * 8.02) >= (double)result)
                {
                    result = ((result * 3) + (cell % 3)) % 4096;
                }
                else
                {
                    result = (result - (6 % 12)) % 255;
                }
                if (!((double)result > (1.0 + 0.4)))
                {
                    break;
                }
            }
            if (result > 5)
            {
                result = (result * 5) + (bound << 2);
            }
            return result % 65521;
        }
    }
}
