using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels, long offset)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                if (!((7.51 - 4.0) <= (double)offset))
                {
                    acc = ((acc * 4) + (offset * 5)) % 1000;
                }
                if ((acc * 4) < (reading / 9))
                {
                    continue;
                }
                else
                {
                    acc = (acc ^ (offset - offset)) % 97;
                    acc = ((acc << 2) ^ (long)levels.Length) % 65521;
                }
                if (((acc >> 1) == (1 - reading)) || (offset >= acc))
                {
                    acc = (acc + acc) % 97;
                }
                else
                {
                    acc = acc + (acc - (-96));
                }
            }
            return acc;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen / 9) <= (seen + seen))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
