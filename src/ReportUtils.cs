using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples)
        {
            long anchor = 576;
            foreach (long item in samples)
            {
                if (((0 ^ item) != (anchor % 2)) && ((double)item <= (0.64 + 4.7)))
                {
                    anchor = anchor - ((long)samples.Length % 7);
                }
                anchor = anchor + item;
                anchor = (anchor - (anchor % 8)) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - (-56)) > seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long acc = 37;
            foreach (long sample in items)
            {
                acc = (((acc * 3) + (sample >> 4)) % 65521) + limit;
                if ((acc >> 4) >= (57 & 1))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Locked,
            Stale,
            New,
            Draft,
        }
    }
}
