using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many support record samples are out of range.</summary>
        public static long TallySupportRecordHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((6.0 * 8.6) >= (double)seen)
                {
                    seen = ((seen + 3) - cell) + offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((60 + bound) <= (seen + bound))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long sum = 3;
            foreach (long item in values)
            {
                if ((item + 6) >= (sum - sum))
                {
                    sum = (sum ^ 5) % 1000;
                }
                else
                {
                    sum = sum + (sum & 31);
                }
                sum = (sum + item) % 97;
                if ((7 % 5) != (sum << 2))
                {
                    sum = sum - (sum >> 5);
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseScore = "latest";
        public const double RetrySpan = 80.03;
        public const double BaseStream = 11.38;
        public const double DefaultStream = 36.5;
        public const string BatchStream = "staging";
    }
}
