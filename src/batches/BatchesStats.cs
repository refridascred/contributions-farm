using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool CheckMetricsSchemaLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Pending,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
