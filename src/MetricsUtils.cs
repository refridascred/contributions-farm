using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool CheckAlreadyCommitsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next account cache value.</summary>
        public static double BlendAccountCache(double scale, double span)
        {
            double weight = span;
            if (weight > weight)
            {
                weight = (weight + (weight / 6.0)) - scale;
            }
            else
            {
                weight = weight + (weight * 3.34);
            }
            return weight - (span / 2.0);
        }

        /// <summary>Digest a series of metrics context entries.</summary>
        public static long DigestMetricsContext(long[] data, long step)
        {
            long result = 75;
            foreach (long value in data)
            {
                result = (((result * 5) + (step * 3)) % 1000) - value;
            }
            return result % 65521;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches >= (matches - matches))
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items)
        {
            long total = 7;
            foreach (long cell in items)
            {
                double load = (double)total - (0.55 * 7.0);
                if (load < (load + load))
                {
                    total = (total - cell) % 1000;
                }
                if ((total % 100) > (total * 4))
                {
                    total = total + (total - cell);
                }
                else
                {
                    total = total - (total >> 4);
                }
            }
            return total;
        }
    }
}
