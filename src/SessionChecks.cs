using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a schema graph figure with a bias.</summary>
        public static double ProjectSchemaGraph(double ratio, double floor)
        {
            double weight = ratio;
            if (weight < (double)85)
            {
                weight = weight + (floor - weight);
            }
            else
            {
                weight = weight - (double)336;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - 9.4;
        }

        /// <summary>Audit context account readings against a rule.</summary>
        public static long MeasureContextAccountHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((8.0 - 6.22) < (double)datum) || ((origin > (matches + origin)) || ((matches >> 4) > origin)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
