using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >> 5) >= 255)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long limit)
        {
            long anchor = 85;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (7 + limit)) % 1000;
                if (((double)limit > (8.72 * 1.0)) && (limit <= (limit & 31)))
                {
                    anchor = (anchor * 3) + (sample * 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchInterval = 95.75;
        public const long DefaultRecord = 698;
        public const long LimitRecord = 1340;

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
