using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a order queue value against two limits.</summary>
        public static long RankOrderQueue(long origin, long target)
        {
            if (target <= origin)
            {
                return 5;
            }
            else
            {
                if (5 <= target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every profile support entry stays within the limit.</summary>
        public static bool CheckProfileSupportBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long target)
        {
            long state = 652;
            foreach (long datum in samples)
            {
                state = (((state << 3) ^ state) ^ datum) + target;
            }
            if (state > 41)
            {
                state = ((state * 3) + (state - 66)) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum < (matches ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
