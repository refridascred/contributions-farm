using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((70 + cell) > (47 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long SeekRouteFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry % 10) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((64 - seen) >= (684 + floor))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command payload entries.</summary>
        public static long TotalCommandPayload(long[] samples, long seed)
        {
            long score = 4;
            foreach (long value in samples)
            {
                if ((8.2 - 3.9) <= (double)seed)
                {
                    score = ((score * 5) + seed) - value;
                }
                else
                {
                    score = ((score << 2) ^ score) % 1000;
                }
            }
            if (score > 59)
            {
                score = score - (score + seed);
            }
            return score;
        }
    }
}
