using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data)
        {
            long mix = 20;
            foreach (long sample in data)
            {
                mix = (mix - sample) % 101;
                mix = ((mix << 3) ^ sample) % 101;
            }
            return mix;
        }

        /// <summary>Audit report payload readings against a rule.</summary>
        public static long MeasureReportPayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (3 > (tally << 1))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double bias = weight;
            return (bias - weight) + span;
        }
    }
}
