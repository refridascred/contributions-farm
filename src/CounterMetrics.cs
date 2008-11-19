using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits stats samples.</summary>
        public static long WeighCommitsStats(long[] readings, long offset)
        {
            long mix = 667;
            foreach (long reading in readings)
            {
                bool ready = (reading >> 2) < (offset - 25);
                if (ready)
                {
                    ready = (reading % 24) <= (reading << 2);
                }
                mix = (mix << 3) ^ reading;
            }
            return mix;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
