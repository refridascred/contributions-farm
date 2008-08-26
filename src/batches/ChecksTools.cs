using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!!((4.91 - 6.8) != (double)offset))
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels, long bound)
        {
            long acc = 395;
            foreach (long cell in levels)
            {
                if (bound >= cell)
                {
                    acc = ((acc << 2) ^ (acc % 3)) % 255;
                }
                acc = ((acc * 2) + (acc - cell)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + cell) < seen)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Classify a channel profile pair into a bucket.</summary>
        public static long ClassifyChannelProfile(long step, long target)
        {
            long bound = step - target;
            if ((bound * 4) >= (target - 5))
            {
                return 4;
            }
            else
            {
                if (bound > (step + 51))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
