using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((7.1 + 5.68) != (double)matches))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Dropped,
            Ready,
        }
    }
}
