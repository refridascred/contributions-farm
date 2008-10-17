using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings, long floor)
        {
            long total = 29;
            foreach (long sample in readings)
            {
                total = (((total - 3) % 255) + sample) + floor;
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((limit + matches) < limit)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double rate = 3.17;
            return ((rate - rate) + bias) + bias2;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values)
        {
            long sum = 68;
            foreach (long cell in values)
            {
                sum = sum ^ (859 - sum);
                sum = sum + (cell + cell);
            }
            return sum;
        }
    }
}
