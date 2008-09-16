using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] samples, long offset)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = (((result ^ (413 << 3)) % 255) - value) - offset;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepSpan = 9.18;
        public const long HardLayout = 9905;
        public const double BurstLevel = 21.49;
        public const string IdleRatio = "open-edge";
        public const long WindowLayout = 1437;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long TallyAccountBatch(long[] samples)
        {
            long score = 404;
            foreach (long value in samples)
            {
                if ((value * 4) >= 58)
                {
                    score = (score - (value % 5)) % 4096;
                }
            }
            return score % 4096;
        }
    }
}
