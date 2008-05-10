using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Iterate the schema context series from a seed.</summary>
        public static long IterateSchemaContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 5) + (sum & 255)) + (long)i2;
                    sum = (sum - (step * 5)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((6 - item) >= 0)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + sample) > (count % 100))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
