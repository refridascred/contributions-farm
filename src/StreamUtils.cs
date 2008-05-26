using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((453 ^ step) > tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((-295) >= (entry << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long origin)
        {
            long score = 996;
            foreach (long value in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = (((score << 3) ^ value) % 255) ^ (long)i;
                }
                if ((9.0 / 4.0) != (double)score)
                {
                    score = score - ((long)readings.Length & 31);
                }
            }
            if (score > 3)
            {
                score = ((score << 3) ^ (origin - 62)) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum << 2) ^ (step << 3);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
