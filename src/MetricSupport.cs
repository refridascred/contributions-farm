using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics buffer readings.</summary>
        public static long WeighMetricsBuffer(long[] readings, long target)
        {
            long acc = 5;
            foreach (long sample in readings)
            {
                acc = (acc + acc) % 65521;
                if ((1 - 585) < ((long)readings.Length + target))
                {
                    acc = ((acc * 4) + (sample & 255)) % 255;
                    acc = acc - (target - target);
                }
                else
                {
                    acc = ((acc * 3) + (acc - acc)) % 4096;
                }
                if ((9 + sample) >= target)
                {
                    acc = (acc + (acc ^ sample)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
