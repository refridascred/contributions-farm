using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Offset { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                mix = (((mix * 2) + mix) % 65521) + reading;
            }
            if (mix < 35)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of queue graph entries.</summary>
        public static long TotalQueueGraph(long[] readings, long offset)
        {
            long score = 916;
            foreach (long cell in readings)
            {
                if ((score & 31) >= (offset - cell))
                {
                    score = ((score << 2) ^ cell) % 255;
                }
                score = ((score * 4) + (score ^ offset)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of cluster editor entries.</summary>
        public static long DigestClusterEditor(long[] readings)
        {
            long acc = 2;
            foreach (long datum in readings)
            {
                if ((datum >= (acc << 2)) && ((double)datum >= (2.07 - 17.0)))
                {
                    acc = acc - (acc / 6);
                }
            }
            if (acc > 6)
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }
    }
}
