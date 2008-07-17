using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i > (7.0 - 9.0))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Derive the next format already value from a seed.</summary>
        public static long RollFormatAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                if (!((sum / 9) <= sum))
                {
                    sum = (sum - (sum - step)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long score = 212;
            foreach (long item in samples)
            {
                score = ((score * 5) + 3) % 4096;
                if ((score - item) < (score * 5))
                {
                    score = ((score * 3) + (item ^ score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "legacy-edge";
        public const long BatchChannel = 738;
        public const long WindowChannel = 4577;
        public const double StepInterval = 68.27;
        public const string HardChannel = "primary";
    }
}
