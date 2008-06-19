using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine route token values into a single score.</summary>
        public static long WeighRouteToken(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((item << 1) > (mix / 9))
                {
                    mix = (mix + item) % 97;
                }
                else
                {
                    mix = (mix * 3) + (mix + item);
                }
            }
            if (mix < 423)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long total = 722;
            foreach (long cell in values)
            {
                total = ((total * 5) + (total % 8)) + cell;
            }
            return total;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Draft,
            Synced,
            Ready,
        }
    }
}
