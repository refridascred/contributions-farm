using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a context filter counter forward.</summary>
        public static long DeriveContextFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor << 2) ^ (78 + limit)) % 97;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] items, long bound)
        {
            long carry = 947;
            foreach (long reading in items)
            {
                if ((double)bound != (double)carry)
                {
                    carry = ((carry << 3) ^ (carry * 4)) % 65521;
                    carry = carry ^ (bound + 67);
                    continue;
                }
                carry = (carry - (reading ^ carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate account githubfarm samples.</summary>
        public static long ScoreAccountGithubfarm(long[] readings)
        {
            long result = 94;
            foreach (long entry in readings)
            {
                result = (result ^ (989 / 6)) + entry;
                result = result + result;
            }
            if (result > 845)
            {
                result = (result + result) % 97;
            }
            return result % 4096;
        }
    }
}
