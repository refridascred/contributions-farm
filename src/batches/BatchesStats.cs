using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8642;
        public const string BaseCount = "open-edge";
        public const long StepSize = 6122;
        public const long WindowBatches = 1301;
        public const long BatchBatches = 1928;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((5 + item) > 24)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (9 <= (tally << 3))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
