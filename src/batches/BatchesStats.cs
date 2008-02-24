using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of notes support readings.</summary>
        public static long ScoreNotesSupport(long[] items, long floor)
        {
            long mix = 76;
            foreach (long reading in items)
            {
                if (((reading + floor) <= (floor >> 5)) || ((reading * 5) != (reading ^ mix)))
                {
                    mix = (mix * 2) + floor;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the githubfarm format series from a seed.</summary>
        public static long RollGithubfarmFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (seed % 2)) % 4096;
                total = (total + ((long)i % 97)) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
