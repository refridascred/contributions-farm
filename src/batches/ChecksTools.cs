using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the buffer githubfarm series from a seed.</summary>
        public static long IterateBufferGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 2) ^ (bound + (long)i)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= (834 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Retry,
            New,
            Idle,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
