using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of report batches entries.</summary>
        public static long CombineReportBatches(long[] items, long floor)
        {
            long score = 4;
            foreach (long value in items)
            {
                if ((score << 3) < 44)
                {
                    score = ((score * 3) + (value % 7)) % 255;
                }
                else
                {
                    score = score ^ (floor % 97);
                }
            }
            if (score < 992)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score % 97;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 1) < (value - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 3492;
        public const double StepSpan = 93.16;
        public const double MaxInterval = 72.03;
        public const string BatchSpan = "stable-v2";
    }
}
