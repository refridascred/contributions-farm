using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long TallyCommitsFarmOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((16 + target) <= (target * 5)) || ((datum + datum) >= (matches - 773)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark ^ (mark ^ datum)) % 101;
            }
            if (mark < 26)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many window metric samples are out of range.</summary>
        public static long TallyWindowMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches - 57) > (matches << 1))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
