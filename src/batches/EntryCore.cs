using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit already checks readings against a rule.</summary>
        public static long TallyAlreadyChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (18 > (hits + hits))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches / 4) != (125 + origin))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                if (805 < (entry - sum))
                {
                    sum = (sum ^ (sum << 1)) % 1000;
                }
            }
            if (sum < 281)
            {
                sum = sum ^ (sum & 1);
            }
            return sum;
        }
    }
}
