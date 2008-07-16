using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a contributi order reading.</summary>
        public static double BlendContributiOrder(double weight, double floor)
        {
            double load = (double)91 * 1.32;
            if (load <= (weight * 2.57))
            {
                load = (load + (weight - weight)) - floor;
            }
            return load + weight;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(38 <= reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings, long origin)
        {
            long total = 94;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (((total << 2) ^ (origin % 8)) % 101) ^ (long)i;
                }
                total = ((total << 2) ^ (reading / 6)) % 101;
            }
            if (total < 0)
            {
                total = (total ^ total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry >= (floor & 127))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long origin)
        {
            long result = 7;
            foreach (long datum in samples)
            {
                result = ((result + result) % 97) + datum;
                result = ((result * 3) + (569 - 827)) % 101;
                result = result + (origin + result);
            }
            return result % 1000;
        }
    }
}
