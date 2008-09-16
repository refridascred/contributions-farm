using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (4.46 - 4.4))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 3) ^ (seed ^ seed);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (step > (step * 5))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Locate a contributi stats reading by value.</summary>
        public static long FindContributiStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double scale, double span)
        {
            double rate = scale + span;
            if (rate < span)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + 9.3;
        }
    }
}
