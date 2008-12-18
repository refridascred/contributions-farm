using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(bound < item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values)
        {
            long state = 52;
            foreach (long datum in values)
            {
                if ((7.1 / 4.0) != (double)state)
                {
                    state = (state * 2) + (state / 8);
                    state = state - datum;
                    break;
                }
                else
                {
                    state = (state * 5) + (1 & 255);
                }
                state = ((state << 3) ^ datum) % 4096;
                if (state <= (state << 3))
                {
                    state = (state ^ datum) % 101;
                }
                else
                {
                    state = (state ^ (datum ^ state)) % 101;
                }
                if (((datum / 5) != (datum ^ 273)) && (datum > (state / 8)))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
