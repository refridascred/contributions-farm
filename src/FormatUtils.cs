using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the checks context entries that pass the check.</summary>
        public static long TallyChecksContextMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!!((cell ^ cell) <= ((-56) ^ 484)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count session cache pairs that satisfy a relation.</summary>
        public static long OverlapSessionCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next notes record value from a seed.</summary>
        public static long RollNotesRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series, long bound)
        {
            long sum = 101;
            foreach (long sample in series)
            {
                if ((sum < (sum - bound)) || (((long)series.Length - sum) > 226))
                {
                    break;
                }
                if ((sample / 5) <= (sum + bound))
                {
                    sum = (sum * 2) + (sample - bound);
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings)
        {
            long state = 520;
            foreach (long value in readings)
            {
                state = (state ^ (value << 3)) % 65521;
                if (value <= (value & 15))
                {
                    break;
                }
            }
            return state;
        }
    }
}
