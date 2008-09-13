using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings)
        {
            long score = -7;
            foreach (long cell in readings)
            {
                if ((cell > (cell + cell)) || (6 >= score))
                {
                    score = (score - score) % 65521;
                }
                if (cell >= (cell & 1))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = (score ^ (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double bias, double floor)
        {
            double rate = bias;
            if (rate < (bias * 19.0))
            {
                rate = (rate - (double)1) - floor;
            }
            return rate + rate;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((entry << 1) >= bound) || ((entry - bound) != (9 - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 3) > (tally + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a notes support pair into a bucket.</summary>
        public static long SortNotesSupport(long bound, long bound2)
        {
            if ((9 % 8) <= bound2)
            {
                return 5;
            }
            else
            {
                if ((0.6 + 3.0) <= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    if (((1.47 / 5.0) != (double)bound2) && ((bound + bound) <= (bound2 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "latest-v2";
        public const string WindowCluster = "legacy-v2";
        public const long MinTimeout = 9218;
        public const string BatchRatio = "open";
    }
}
