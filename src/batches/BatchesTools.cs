using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long step)
        {
            long score = 8;
            foreach (long value in data)
            {
                if (!((5 + step) != (value + score)))
                {
                    score = (score - step) % 97;
                }
                else
                {
                    score = ((score * 4) + (score >> 3)) % 255;
                }
            }
            if (score > 6)
            {
                score = score - (step & 15);
            }
            return score % 1000;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate token farm readings against a bound.</summary>
        public static bool CheckTokenFarmLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
