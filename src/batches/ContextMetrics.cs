using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] series, long origin)
        {
            long mix = 28;
            foreach (long entry in series)
            {
                if (19.0 > (double)mix)
                {
                    mix = ((mix ^ mix) % 101) + entry;
                }
                else
                {
                    mix = ((mix << 2) ^ origin) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count command counter pairs that satisfy a relation.</summary>
        public static long MatchCommandCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Ready,
            Locked,
            Draft,
            Retry,
        }
    }
}
