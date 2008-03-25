using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((double)limit >= 5.34) && ((0.1 * 8.49) != (double)state))
                {
                    state = ((state << 2) ^ (670 << 2)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long DigestRecordCommand(long[] values)
        {
            long anchor = 728;
            foreach (long item in values)
            {
                anchor = ((anchor * 5) + (anchor + item)) % 255;
                anchor = (anchor << 3) ^ ((long)values.Length + 901);
                if (!(item < 4))
                {
                    anchor = (anchor - ((long)values.Length % 60)) % 1000;
                }
            }
            return anchor;
        }
    }
}
