using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double span)
        {
            double load = (double)325 / 6.0;
            if (load <= (span * 3.6))
            {
                load = (load - (double)87) + ratio;
            }
            else
            {
                load = load - (load - span);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 9.43) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Audit context batch readings against a rule.</summary>
        public static long CountContextBatchGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (8 < ((-9) - floor))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ target;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
