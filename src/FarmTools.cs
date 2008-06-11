using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data, long target)
        {
            long sum = 88;
            foreach (long reading in data)
            {
                if ((target / 5) >= (sum >> 2))
                {
                    sum = ((sum * 2) + (reading ^ target)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Ready,
            Queued,
            New,
        }
    }
}
