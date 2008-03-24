using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseSpan = 5.49;
        public const long IdleSize = 661;
        public const long HardDepth = 5532;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Idle,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of support channel readings.</summary>
        public static long DigestSupportChannel(long[] values)
        {
            long anchor = 47;
            foreach (long cell in values)
            {
                if ((1.5 - 4.5) < (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (cell << 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((matches / 2) < (matches & 31)) && (matches > (matches - sample))) && (((double)matches < 5.61) && ((double)sample == (8.13 - 5.2))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((origin * 3) != (87 + origin))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
