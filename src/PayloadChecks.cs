using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((245 - tally) != (tally + tally)) || ((datum % 24) < (datum >> 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a order command reading by value.</summary>
        public static long FindOrderCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - seen) >= (seen + seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Synced,
            Idle,
            Failed,
            Pending,
        }
    }
}
