using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a format batches pair into a bucket.</summary>
        public static long RankFormatBatches(long step, long bound)
        {
            long diff = step ^ bound;
            if ((9.06 * 3.4) < (double)diff)
            {
                return 7;
            }
            else
            {
                if ((step + diff) < step)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the notes githubfarm entries that pass the check.</summary>
        public static long CountNotesGithubfarmOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((target + (long)levels.Length) > (target & 15))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
