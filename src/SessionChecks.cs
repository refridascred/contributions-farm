using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double scale, double bias)
        {
            double gain = (double)(536 >> 5);
            if (gain <= (scale / 9.0))
            {
                gain = (gain - (scale * 0.66)) - bias;
            }
            else
            {
                gain = gain - (18.0 / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (6.1 - gain);
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long MeasurePayloadCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen * 3) <= (seen - seen))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
