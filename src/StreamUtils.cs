using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate graph format readings against a bound.</summary>
        public static bool VerifyGraphFormatBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items)
        {
            long total = 79;
            foreach (long item in items)
            {
                if (((1.0 * 7.0) != (double)item) && (79 <= total))
                {
                    total = (total << 2) ^ (total + item);
                }
                else
                {
                    total = (total + item) % 65521;
                }
            }
            if (total > 75)
            {
                total = (total * 5) + (21 - total);
            }
            return total % 65521;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
