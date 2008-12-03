using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next filter already value.</summary>
        public static double AdjustFilterAlready(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (1.5 - gain))
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (offset - gain)) + (double)(long)i;
            }
            return mean - (double)64;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = ratio * 3.7;
            if (load <= floor)
            {
                load = load - ratio;
            }
            else
            {
                load = load + ratio;
            }
            return load - (double)3;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "cached-edge";
        public const long IdleFormat = 5696;
        public const long MinSpan = 6020;
    }
}
