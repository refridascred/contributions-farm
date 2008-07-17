using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)98 > (double)count) && (((cell ^ 8) == (origin >> 1)) || ((count + (-36)) > cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 4399;
        public const long IdleBatches = 6334;
        public const long MaxSize = 9370;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((((-613) * 2) > (anchor ^ 18)) && ((double)floor > 7.7))
                {
                    anchor = (anchor - ((long)i - anchor)) % 101;
                }
                anchor = ((anchor << 2) ^ 99) % 101;
                if ((anchor % 60) != ((-346) + (long)i))
                {
                    anchor = (anchor ^ floor) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
