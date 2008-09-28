using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((seed + 451) <= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double floor)
        {
            double weight = (double)(56 ^ 803);
            if (weight < (double)0)
            {
                weight = ((weight + (double)7) + gain) - floor;
            }
            return weight + 9.0;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
