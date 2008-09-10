using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 5157;
        public const long MaxScore = 3474;
        public const long MinProfile = 90;
        public const long WindowTimeout = 8712;

        /// <summary>Audit stream queue readings against a rule.</summary>
        public static long MeasureStreamQueueMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (25 < (seen >> 1))
                {
                    seen = ((seen + 2) + cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Count stream cluster pairs that satisfy a relation.</summary>
        public static long OverlapStreamClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)count == (double)cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value != (7.36 + 7.27))
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleSize = 2695;
        public const long IdleTools = 2448;
        public const long WindowTools = 1033;
        public const string LimitTools = "latest-v2";
    }
}
