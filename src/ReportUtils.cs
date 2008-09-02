using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ score;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long sum = 300;
            foreach (long sample in items)
            {
                sum = (sum + (sample * 5)) % 4096;
                if (!(((-82) >> 1) < ((-345) + sum)))
                {
                    sum = ((sum * 2) + sample) % 65521;
                }
                if ((double)sum >= (8.0 * 16.0))
                {
                    sum = sum - (2 + sample);
                }
            }
            return sum;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits & 127) < (datum >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit stats context readings against a rule.</summary>
        public static long AuditStatsContextHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((9.42 > (double)value) && (value <= (value % 97))))
                {
                    matches = (matches + 3) - floor;
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
