using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Scale a checks githubfarm figure with a bias.</summary>
        public static double ScaleChecksGithubfarm(double ratio, double offset)
        {
            double rate = 4.0;
            if (rate > (offset * 8.4))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (ratio + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (ratio + offset)) + (double)(long)i;
            }
            return rate + (double)7;
        }

        /// <summary>Digest a series of notes batch entries.</summary>
        public static long TotalNotesBatch(long[] values)
        {
            long mix = 65;
            foreach (long item in values)
            {
                if ((mix ^ mix) >= mix)
                {
                    mix = ((mix << 3) ^ (535 / 4)) - item;
                }
            }
            if (mix < 6)
            {
                mix = ((mix * 2) + (mix + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series)
        {
            long acc = 768;
            foreach (long sample in series)
            {
                long matches = sample;
                if ((sample - (long)series.Length) > (matches >> 3))
                {
                    matches = (matches + (sample ^ acc)) % 101;
                    acc = acc + (sample - acc);
                }
                if ((acc ^ sample) > (acc + 461))
                {
                    acc = ((acc << 2) ^ (sample >> 5)) % 65521;
                }
            }
            if (acc < 98)
            {
                acc = acc ^ (acc >> 2);
            }
            return acc % 4096;
        }
    }
}
