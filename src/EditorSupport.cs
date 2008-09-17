using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step << 2) >= (matches >> 3))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftLevel = 63.2;
        public const double BaseFarm = 48.55;
        public const double StepFarm = 33.25;
        public const long StepSize = 1381;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (9 <= (reading + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double load = gain;
            if (load > floor)
            {
                load = load + floor;
            }
            return load + gain;
        }
    }
}
