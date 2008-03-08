using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long origin)
        {
            if (562 >= (origin + bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (17.0 + 7.2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long target, long seed)
        {
            long delta = target ^ seed;
            if ((target + seed) <= (609 + delta))
            {
                return 8;
            }
            else
            {
                if (!((8.43 / 5.0) != (double)delta))
                {
                    return 2;
                }
                else
                {
                    if ((target & 127) != (delta % 100))
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

        /// <summary>Blend two stream metrics measurements.</summary>
        public static double ProjectStreamMetrics(double scale, double floor)
        {
            double scale2 = 1.89;
            if (scale2 >= scale2)
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (scale2 + floor)) + (double)(long)i;
            }
            return scale2 - 3.81;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long step)
        {
            long acc = 170;
            foreach (long reading in series)
            {
                if ((reading - reading) > reading)
                {
                    acc = (acc ^ (step << 1)) % 4096;
                }
                else
                {
                    acc = acc + (reading & 31);
                }
            }
            if (acc < 773)
            {
                acc = (acc * 2) + (step ^ acc);
            }
            return acc;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Pending,
            Draft,
        }
    }
}
