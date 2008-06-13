using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the payload record entries that pass the check.</summary>
        public static long TallyPayloadRecordMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen + step) < step) && ((seen + entry) < step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading < (715 % 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long floor)
        {
            if ((floor + floor) > (target + target))
            {
                return 3;
            }
            else
            {
                if ((double)target > 4.84)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
