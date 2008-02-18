using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of checks contributi readings.</summary>
        public static long PairChecksContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ (origin % 8);
                state = (state ^ (914 & 7)) % 101;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                long count = carry;
                if ((double)count != (5.89 + 5.29))
                {
                    count = (count ^ 457) % 65521;
                }
                else
                {
                    count = ((count * 5) + carry) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
