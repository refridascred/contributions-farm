using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double drift = (double)(659 >> 5);
            if (drift < (double)55)
            {
                drift = (drift + (rate + rate)) - offset;
            }
            return drift + (double)53;
        }
    }
}
