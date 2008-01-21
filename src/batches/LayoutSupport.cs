using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values, long step)
        {
            long total = 92;
            foreach (long entry in values)
            {
                if ((step >> 3) > (total + step))
                {
                    total = total ^ (entry >> 4);
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of cache commits readings.</summary>
        public static long DigestCacheCommits(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                if ((48 / 2) >= (504 - reading))
                {
                    sum = (sum << 2) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally * 4) <= 49)
                {
                    tally = ((tally + 2) + entry) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
