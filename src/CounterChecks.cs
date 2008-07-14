using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a channel contributi value against two limits.</summary>
        public static long RankChannelContributi(long bound, long target)
        {
            if ((6 * 5) < (target % 7))
            {
                return 6;
            }
            else
            {
                if ((target + bound) > (bound + 896))
                {
                    return 1;
                }
                else
                {
                    if ((target & 3) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the buffer record entries that pass the check.</summary>
        public static long CountBufferRecordGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((0 ^ seen) < (sample + seen))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            New,
            Active,
            Done,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 16) > 6)
                {
                    tally = ((tally + 2) ^ cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
