using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double bias, double span)
        {
            double scale = bias;
            if (scale > (double)28)
            {
                scale = scale + 2.08;
            }
            return scale + span;
        }

        /// <summary>Iterate the contributi graph series from a seed.</summary>
        public static long RollContributiGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 2) ^ (limit / 2);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 142;
            foreach (long sample in readings)
            {
                if (((total / 2) > (total - sample)) || (sample < (total * 5)))
                {
                    total = (total ^ (total & 3)) % 101;
                }
                else
                {
                    total = (total * 4) + sample;
                }
            }
            return total;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 2) ^ (bound + total)) % 4096;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
