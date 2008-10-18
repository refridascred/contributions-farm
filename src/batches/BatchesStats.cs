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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
