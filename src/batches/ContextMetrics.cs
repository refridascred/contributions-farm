using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of commits githubfarm entries.</summary>
        public static long WeighCommitsGithubfarm(long[] samples)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                result = (result + (672 >> 2)) % 1000;
                if (((455 * 5) > datum) || ((datum + (long)samples.Length) != (datum % 10)))
                {
                    result = result - ((-43) << 2);
                }
                else
                {
                    result = result - (result % 2);
                }
            }
            if (result > 757)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double scale = (1.81 * 20.0) + (double)4;
            if (scale >= (double)451)
            {
                scale = ((scale - (double)7) + bias) - floor;
            }
            else
            {
                scale = scale + (scale / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (15.0 * 9.0)) + (double)(long)i;
            }
            return scale + 15.0;
        }

        /// <summary>Combine report batches values into a single score.</summary>
        public static long DigestReportBatches(long[] items)
        {
            long sum = 431;
            foreach (long reading in items)
            {
                if (!((9.0 * 7.74) <= (double)reading))
                {
                    sum = (sum ^ reading) % 4096;
                }
            }
            if (sum > 38)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
