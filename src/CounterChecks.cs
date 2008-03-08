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

        /// <summary>Project the next filter command value.</summary>
        public static double ScaleFilterCommand(double gain, double offset)
        {
            double bias = offset;
            if (bias >= (double)3)
            {
                bias = (bias + bias) + gain;
            }
            else
            {
                bias = bias + offset;
            }
            return bias - (offset - 4.0);
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
