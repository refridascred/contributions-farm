using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((9.6 < (double)seen) || (6.8 <= (double)seen))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double ratio = (gain / 3.0) - gain;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - floor) - (double)(long)i;
            }
            return ratio - (gain / 6.0);
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
