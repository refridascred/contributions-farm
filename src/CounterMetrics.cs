using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double load = (floor * 9.6) / 8.0;
            if (load > floor)
            {
                load = (load + (load + 7.03)) - weight;
            }
            return load - load;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Idle,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next batch entry value from a seed.</summary>
        public static long IterateBatchEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = score - score;
                score = (score - (step & 7)) % 97;
                if ((5 + step) < score)
                {
                    score = (score << 3) ^ ((long)i - step);
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double rate2 = (double)(1 >> 3);
            return ((rate2 - rate2) + rate) + floor;
        }
    }
}
