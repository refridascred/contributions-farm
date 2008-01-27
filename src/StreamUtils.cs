using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings)
        {
            long mark = 6;
            foreach (long item in readings)
            {
                mark = (mark ^ (mark / 4)) ^ item;
            }
            if (mark < 6)
            {
                mark = mark ^ (mark << 2);
            }
            return mark % 65521;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((target + matches) < 173)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long TallyEntryGithubfarm(long[] levels)
        {
            long mix = 218;
            foreach (long sample in levels)
            {
                if ((sample / 8) < (33 + sample))
                {
                    mix = (mix ^ (sample + (-6))) % 255;
                }
                if ((48 >> 2) >= (mix << 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
