using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double load = (gain - offset) / 5.0;
            return load + (gain - 6.33);
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if (!(0.6 > (1.75 / 3.0)))
                {
                    mix = ((mix ^ (mix + mix)) % 255) + item;
                }
                else
                {
                    mix = (mix << 3) ^ (71 << 1);
                }
            }
            if (mix < 814)
            {
                mix = (mix + mix) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstFactor = 1082;
        public const double SoftTools = 58.58;
        public const double WindowTools = 51.97;
        public const long BaseTools = 1744;
        public const double LimitTools = 91.17;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long seed)
        {
            long sum = 270;
            foreach (long value in values)
            {
                sum = ((sum - (seed + (long)values.Length)) % 65521) + value;
            }
            return sum;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
