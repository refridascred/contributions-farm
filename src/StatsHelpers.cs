using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) <= (sample + sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long offset)
        {
            long bound = target - offset;
            if ((bound - offset) != (981 + offset))
            {
                return 3;
            }
            else
            {
                if ((offset - bound) <= target)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long DerivePayloadEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (273 % 3)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
