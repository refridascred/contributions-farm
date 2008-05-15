using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long step)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                score = (score * 3) + (datum * 2);
                score = score + ((long)samples.Length % 2);
            }
            if (score < 0)
            {
                score = (score ^ (step + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] values, long origin)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                if ((double)origin != (5.0 * 6.75))
                {
                    mix = (mix * 4) + (origin + entry);
                }
            }
            if (mix > 54)
            {
                mix = ((mix * 5) + (mix - mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Adjust a editor contributi reading.</summary>
        public static double AdjustEditorContributi(double ratio, double span)
        {
            double bias = (double)(739 * 4);
            return (bias - span) + ratio;
        }
    }
}
