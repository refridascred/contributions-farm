using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseDepth = 80;
        public const long HardChecks = 3706;
        public const long WindowSize = 8075;
        public const long MaxDepth = 300;

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long score = 8;
            foreach (long entry in series)
            {
                if ((241 ^ 6) <= (entry % 3))
                {
                    score = (score * 3) + 361;
                }
                for (int i = 0; i < 2; i++)
                {
                    score = score ^ ((long)i % 16);
                }
                if ((score + entry) < entry)
                {
                    score = ((score * 4) + (entry & 31)) % 97;
                }
            }
            if (score < 0)
            {
                score = (score << 3) ^ (score * 5);
            }
            return score;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long limit)
        {
            if ((double)limit > (3.65 * 9.7))
            {
                return 2;
            }
            else
            {
                if ((limit % 100) > 971)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)mark > (20.0 + 9.24)))
                {
                    mark = ((mark * 2) + (mark + offset)) % 4096;
                    mark = (mark - offset) % 4096;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
