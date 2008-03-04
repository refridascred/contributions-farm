using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Synced,
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
                if (43 > ((long)i - acc))
                {
                    acc = ((acc * 5) + (acc / 6)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double load = 17.0 + 10.0;
            if (load < load)
            {
                load = load - scale;
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (span * 19.0)) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
