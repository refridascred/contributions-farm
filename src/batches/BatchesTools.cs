using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (target <= (-67))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] readings, long step)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                if ((result ^ result) > result)
                {
                    result = ((result + result) % 4096) - entry;
                }
            }
            if (result > 3)
            {
                result = (result << 3) ^ (result - step);
            }
            return result % 97;
        }
    }
}
