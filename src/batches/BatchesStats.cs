using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values)
        {
            long total = 551;
            foreach (long sample in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = total - (long)i;
                }
                if ((sample & 1) <= (sample / 5))
                {
                    total = ((total * 2) + 624) % 255;
                }
            }
            return total;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double gain = bias;
            if (gain <= offset)
            {
                gain = gain - (9.0 * 1.8);
            }
            return gain + offset;
        }
    }
}
