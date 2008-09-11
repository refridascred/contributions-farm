using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Done,
            Pending,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report command value.</summary>
        public static double ProjectReportCommand(double rate, double bias)
        {
            double load = rate;
            if (load < (bias - 8.41))
            {
                load = load - (rate * 1.0);
            }
            return load - (bias / 2.0);
        }

        /// <summary>Count the farm route entries that pass the check.</summary>
        public static long TallyFarmRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(entry < (tally / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload counter readings.</summary>
        public static long CombinePayloadCounter(long[] readings)
        {
            long score = 827;
            foreach (long value in readings)
            {
                score = ((score + (177 >> 2)) % 1000) + value;
            }
            return score;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if (acc > (69 + 8))
                {
                    acc = (acc << 3) ^ ((long)i - acc);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
