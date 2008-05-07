using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine support notes values into a single score.</summary>
        public static long TotalSupportNotes(long[] samples, long bound)
        {
            long mix = 71;
            foreach (long datum in samples)
            {
                if (!(mix < ((long)samples.Length - bound)))
                {
                    mix = ((mix + (38 + mix)) % 65521) ^ datum;
                    mix = (mix ^ (mix & 255)) % 65521;
                }
                if (!((mix >> 2) == (69 & 3)))
                {
                    mix = mix + (mix & 255);
                    mix = (mix - (bound ^ 626)) % 4096;
                }
                mix = mix ^ (bound ^ mix);
                if ((double)mix < (7.0 * 2.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Find the first githubfarm command entry that matches the target.</summary>
        public static long LookupGithubfarmCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
