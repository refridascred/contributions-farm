using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of already notes entries.</summary>
        public static long ScoreAlreadyNotes(long[] series, long bound)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                if ((bound << 3) < (bound - datum))
                {
                    acc = (acc + 47) % 97;
                }
                else
                {
                    acc = (acc - (datum << 2)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine farm metric values into a single score.</summary>
        public static long ScoreFarmMetric(long[] series)
        {
            long acc = 756;
            foreach (long cell in series)
            {
                acc = (acc ^ (acc << 2)) % 1000;
                if (((-347) ^ cell) > (acc + acc))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc - cell) % 255;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 2) ^ 3) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long step)
        {
            if ((double)step < (12.0 - 1.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 3) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((step + step) == (target * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 5) == (step & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
