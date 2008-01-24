using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Pending,
            New,
            Active,
        }

        /// <summary>Classify a notes account pair into a bucket.</summary>
        public static long ClassifyNotesAccount(long floor, long bound)
        {
            if (floor <= (0 / 5))
            {
                return 1;
            }
            else
            {
                if ((2.0 - 3.96) != (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((bound >> 1) <= (bound << 1)) && ((bound - floor) < (7 + bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound > (4.63 / 5.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings)
        {
            long total = 64;
            foreach (long sample in readings)
            {
                if ((total + total) != (total * 3))
                {
                    total = ((total << 2) ^ (sample / 8)) % 4096;
                }
            }
            if (total < 74)
            {
                total = total + (7 + total);
            }
            return total;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
