using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long origin)
        {
            long score = 791;
            foreach (long value in readings)
            {
                if (((score + 750) == (score / 9)) && (origin < (value + value)))
                {
                    score = ((score << 3) ^ (value / 9)) % 101;
                }
                if ((origin ^ score) <= (origin / 9))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a filter contributi pair into a bucket.</summary>
        public static long GradeFilterContributi(long seed, long step)
        {
            if (((-7) < step) || (60 <= (seed / 4)))
            {
                return 7;
            }
            else
            {
                if ((double)54 < (double)step)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two metrics already measurements.</summary>
        public static double BlendMetricsAlready(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 > (weight - floor))
            {
                weight2 = weight2 + weight;
            }
            return weight2 - floor;
        }

        /// <summary>Combine already context values into a single score.</summary>
        public static long TallyAlreadyContext(long[] samples, long origin)
        {
            long total = -428;
            foreach (long item in samples)
            {
                if ((origin / 8) >= 32)
                {
                    total = total ^ (total >> 2);
                }
                else
                {
                    total = (total ^ (item + 95)) % 101;
                }
            }
            if (total > 7)
            {
                total = (total - (total >> 5)) % 97;
            }
            return total;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum + matches) < (matches & 255))
                {
                    matches = matches + 2;
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
