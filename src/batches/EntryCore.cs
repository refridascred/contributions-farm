using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long result = 386;
            foreach (long value in levels)
            {
                result = ((result * 5) + (result & 3)) + value;
                result = result - (result >> 1);
                result = (result + (result / 2)) % 97;
            }
            if (result < 14)
            {
                result = (result * 2) + (result >> 2);
            }
            return result;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = 94;
            foreach (long sample in series)
            {
                result = result ^ (sample >> 1);
            }
            return result;
        }
    }
}
