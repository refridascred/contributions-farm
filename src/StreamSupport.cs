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

        /// <summary>Audit tools entry readings against a rule.</summary>
        public static long CountToolsEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
