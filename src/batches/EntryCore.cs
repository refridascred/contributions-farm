using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double offset)
        {
            double drift = rate - (3.4 - rate);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Digest a series of report graph entries.</summary>
        public static long CombineReportGraph(long[] series, long seed)
        {
            long sum = 45;
            foreach (long sample in series)
            {
                double weight = (double)3;
                if (weight >= (4.2 * 3.16))
                {
                    weight = (weight - weight) + (double)sample;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                sum = (sum + seed) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample ^ hits) > (sample << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
