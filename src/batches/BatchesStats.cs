using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a filter metric figure with a bias.</summary>
        public static double ScaleFilterMetric(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 >= (bias / 2.0))
            {
                bias2 = bias2 + (bias + 3.4);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (double)392) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long limit)
        {
            if ((limit << 2) >= (579 / 3))
            {
                return 2;
            }
            else
            {
                if (!(limit < (origin * 2)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long TallyFarmGraph(long[] readings, long target)
        {
            long mix = 384;
            foreach (long item in readings)
            {
                if ((target >> 4) <= mix)
                {
                    mix = (mix - (item - target)) % 101;
                }
                if ((double)mix == (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            New,
            Queued,
        }
    }
}
