using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(3.5 <= (double)count) || (((double)count <= 9.0) && (count < (value + 763))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long AuditQueueStreamOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((count - entry) <= entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
