using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data)
        {
            long result = 89;
            foreach (long datum in data)
            {
                if ((result - result) <= ((long)data.Length * 2))
                {
                    result = result ^ result;
                    break;
                }
                if ((result + result) >= (datum << 1))
                {
                    result = (result - (datum + result)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ (datum + datum)) % 4096;
                }
            }
            if (result > 621)
            {
                result = ((result * 3) + result) % 97;
            }
            return result;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((3.9 + 17.0) < (double)matches)
                {
                    matches = ((matches + 2) ^ cell) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
