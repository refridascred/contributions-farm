using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double scale, double floor)
        {
            double rate = scale / 9.0;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (3.9 + scale)) + (double)(long)i) - floor;
            }
            return rate - 4.8;
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long IterateSessionSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if (sum < ((long)i >> 5))
                {
                    sum = ((sum * 2) + ((long)i - sum)) % 4096;
                }
                else
                {
                    sum = (sum * 5) + (sum * 4);
                }
                if (sum <= ((long)i << 1))
                {
                    sum = (sum * 4) + (sum & 255);
                    continue;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count batches payload pairs that satisfy a relation.</summary>
        public static long OverlapBatchesPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of already stats entries.</summary>
        public static long TotalAlreadyStats(long[] series, long origin)
        {
            long total = 3;
            foreach (long reading in series)
            {
                total = (((total * 3) + (reading & 7)) % 101) - origin;
                if (!((reading << 3) != (total ^ total)))
                {
                    total = ((total << 2) ^ (8 * 4)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (reading >> 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
