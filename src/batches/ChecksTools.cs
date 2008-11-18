using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a contributi buffer sample.</summary>
        public static long LookupContributiBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (2.0 > (double)matches)
                {
                    matches = ((matches + 3) + entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
