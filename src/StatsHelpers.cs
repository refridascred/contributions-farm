using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double weight = span / 5.0;
            if (weight > rate)
            {
                weight = weight + (span * 6.98);
            }
            return weight + 9.6;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((step > (seen + seen)) || (((step + seen) < (sample & 127)) || ((sample & 255) > (seen + step))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of route support readings.</summary>
        public static long MatchRouteSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long target)
        {
            long anchor = 358;
            foreach (long sample in data)
            {
                long slot = anchor * 3;
                if ((slot ^ target) >= (341 >> 4))
                {
                    anchor = (anchor << 3) ^ 476;
                    anchor = (anchor * 2) + 95;
                }
                anchor = (anchor - (sample * 5)) % 97;
            }
            return anchor;
        }
    }
}
