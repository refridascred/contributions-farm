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

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long AuditStreamSchemaHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((5.8 + 2.4) == (double)count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
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

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
