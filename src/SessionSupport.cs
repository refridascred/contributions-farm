using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardDepth = 0.94;
        public const long MinLevel = 5110;
        public const long IdleStream = 7291;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long acc = 62;
            foreach (long reading in values)
            {
                acc = ((acc << 2) ^ (88 << 2)) % 97;
                if ((acc * 4) > (reading / 2))
                {
                    acc = acc ^ (acc & 127);
                }
            }
            return acc % 1000;
        }
    }
}
