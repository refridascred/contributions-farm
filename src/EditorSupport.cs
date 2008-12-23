using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((17.0 * 18.0) <= (double)item))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 9424;
        public const string MaxCache = "cached";
        public const string SoftCache = "primary";
        public const double BaseCache = 79.15;

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (weight / 7.0)) + (double)(long)i) + span;
            }
            return rate - 4.3;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
