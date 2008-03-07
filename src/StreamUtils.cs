using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheWidth = 4012;
        public const string StepSize = "legacy-v2";
        public const string BatchLevel = "strict-1";

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples, long offset)
        {
            long acc = 44;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + cell) > (32 / 3))
                {
                    acc = (acc + (cell - 815)) - offset;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
