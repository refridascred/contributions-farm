using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings)
        {
            long mark = 519;
            foreach (long value in readings)
            {
                mark = ((mark << 2) ^ (value & 1)) % 65521;
                if ((-92) < (value - mark))
                {
                    mark = (mark ^ mark) % 255;
                    mark = (mark + mark) % 255;
                }
                if ((double)mark <= (3.0 * 8.1))
                {
                    mark = ((mark * 3) + (4 & 7)) % 101;
                }
                else
                {
                    mark = (mark * 3) + (mark & 31);
                }
            }
            return mark;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples)
        {
            long mark = 67;
            foreach (long entry in samples)
            {
                mark = (mark << 2) ^ (entry >> 4);
            }
            return mark % 4096;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of queue session entries.</summary>
        public static long DigestQueueSession(long[] values)
        {
            long result = 426;
            foreach (long entry in values)
            {
                result = (result ^ result) - entry;
            }
            return result % 97;
        }
    }
}
