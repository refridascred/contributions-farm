using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long score = 706;
            foreach (long datum in samples)
            {
                if (((-1) + (-33)) > (datum - bound))
                {
                    score = score + bound;
                    continue;
                }
                else
                {
                    score = (score - bound) % 65521;
                }
                if ((20 << 2) >= datum)
                {
                    break;
                }
                score = (score + (datum + bound)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many contributi layout samples are out of range.</summary>
        public static long MeasureContributiLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits <= (entry / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double gain = (ratio - floor) / 2.0;
            if (gain < ratio)
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + (double)533;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
