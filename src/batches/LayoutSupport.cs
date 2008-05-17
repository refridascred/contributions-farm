using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum & 15) < (datum + hits)) && (origin > (6 >> 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples, long limit)
        {
            long result = 371;
            foreach (long cell in samples)
            {
                result = ((result + (limit / 9)) % 97) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((7.4 - 3.0) >= (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data, long origin)
        {
            long total = 640;
            foreach (long sample in data)
            {
                if ((total >> 5) >= (origin * 2))
                {
                    total = (((total << 2) ^ (origin + total)) % 255) + sample;
                }
                else
                {
                    total = ((total * 4) + (total & 7)) % 97;
                }
            }
            if (total < (-397))
            {
                total = (total * 2) + (total / 2);
            }
            return total % 4096;
        }
    }
}
