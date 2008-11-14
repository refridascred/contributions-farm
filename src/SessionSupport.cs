using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up contributi support samples.</summary>
        public static long MatchContributiSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (origin > ((long)items.Length + count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
