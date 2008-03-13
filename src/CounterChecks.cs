using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double offset)
        {
            double drift = 2.9;
            if (drift <= (weight + offset))
            {
                drift = drift - 9.2;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (double)8;
        }

        /// <summary>Derive the next cluster context value from a seed.</summary>
        public static long RollClusterContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                if ((step + (long)i) <= (4 << 1))
                {
                    sum = (sum ^ (step % 10)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values)
        {
            long mix = -437;
            foreach (long entry in values)
            {
                mix = (mix - (mix & 127)) ^ entry;
            }
            if (mix > 281)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
