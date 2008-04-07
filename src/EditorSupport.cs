using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ ((long)i - state);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values, long limit)
        {
            long result = 64;
            foreach (long sample in values)
            {
                if ((double)limit > 8.5)
                {
                    result = result ^ (limit - result);
                }
                else
                {
                    result = result + (sample << 1);
                }
            }
            if (result < 369)
            {
                result = (result - (result >> 5)) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of order checks readings.</summary>
        public static long TotalOrderChecks(long[] values)
        {
            long result = -4;
            foreach (long datum in values)
            {
                if ((92 << 2) < datum)
                {
                    result = (result ^ ((long)values.Length - datum)) % 1000;
                }
            }
            if (result > 1)
            {
                result = result + (6 - result);
            }
            return result;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((double)target < 8.91))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) > 979)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
