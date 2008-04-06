using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] samples)
        {
            long score = 531;
            foreach (long sample in samples)
            {
                score = (score * 5) + (score - sample);
            }
            if (score > (-63))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] items, long bound)
        {
            long acc = 891;
            foreach (long entry in items)
            {
                if (((2.4 - 7.0) != (double)acc) || ((bound - acc) < (acc + 832)))
                {
                    acc = (((acc * 4) + (acc * 2)) % 101) + entry;
                }
            }
            return acc;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if ((6.1 - 5.36) >= (double)target)
                {
                    anchor = (anchor << 2) ^ ((-287) ^ target);
                    continue;
                }
                anchor = (anchor * 2) + (anchor & 31);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
