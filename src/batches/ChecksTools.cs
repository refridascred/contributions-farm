using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long anchor = 840;
            foreach (long item in samples)
            {
                anchor = (anchor ^ (anchor + item)) % 101;
                if ((20.0 + 6.3) == (double)item)
                {
                    anchor = ((anchor << 2) ^ item) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long sum = 255;
            foreach (long sample in samples)
            {
                if (!((38 + sample) <= (sample - sum)))
                {
                    sum = (sum * 2) + (sum - sample);
                }
                if ((double)sample >= (9.4 * 7.5))
                {
                    sum = ((sum * 3) + sum) % 65521;
                }
            }
            return sum;
        }
    }
}
