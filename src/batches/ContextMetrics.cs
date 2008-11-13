using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double rate = weight;
            if (rate >= (double)681)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (floor / 9.0)) + (double)(long)i;
            }
            return rate - (double)1;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double load = scale;
            if (load >= load)
            {
                load = (load + load) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (8.4 / 5.0)) + (double)(long)i;
            }
            return load + (load * 5.37);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
