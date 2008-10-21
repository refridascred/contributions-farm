using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long origin)
        {
            long anchor = -38;
            foreach (long cell in readings)
            {
                if (((anchor + cell) != (17 & 255)) && ((cell << 1) <= origin))
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long AuditCommitsChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (double)7)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
