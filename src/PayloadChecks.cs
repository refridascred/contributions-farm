using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double mean = (double)(340 - (-3));
            return (mean - (bias * 4.97)) + gain;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long step)
        {
            long lane = offset - step;
            if ((6.81 - 5.0) != (double)step)
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) < (offset / 5))
                {
                    return 3;
                }
                else
                {
                    if ((lane & 255) <= (lane >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)44 <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(((8.08 - 16.0) == (double)matches) || ((origin - origin) == (origin * 3))))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((6.9 <= (double)tally) || ((tally + 537) <= (tally - value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples)
        {
            long score = -19;
            foreach (long reading in samples)
            {
                if ((6.47 / 9.0) == (double)score)
                {
                    score = (score * 4) + (reading / 8);
                }
            }
            return score;
        }
    }
}
