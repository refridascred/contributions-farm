using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((limit - 681) >= (35 << 1))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long step)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                carry = carry - (datum + carry);
            }
            if (carry < 983)
            {
                carry = (carry - (step >> 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 10.06;
        public const long RetryWidth = 7705;
        public const long BatchSize = 9592;
        public const long HardScore = 1212;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 77.57;
        public const long BaseEditor = 1281;
        public const string IdleRatio = "local-edge";
        public const long DefaultEditor = 9020;
        public const long IdleTimeout = 5346;

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long MeasureStreamTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (441 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
