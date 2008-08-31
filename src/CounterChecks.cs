using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the tools route series from a seed.</summary>
        public static long SeriesToolsRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (step & 15)) % 4096;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ state) % 65521;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
