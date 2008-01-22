using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if (score <= (score + datum))
                {
                    score = score - datum;
                }
                score = (score - (score << 2)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of already notes entries.</summary>
        public static long CombineAlreadyNotes(long[] items)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                if ((sample + sample) >= (sample + (long)items.Length))
                {
                    anchor = anchor ^ (sample * 2);
                }
                if ((double)sample >= (2.9 - 9.01))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                mix = (mix - (mix + mix)) % 255;
                if ((mix + entry) >= entry)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
