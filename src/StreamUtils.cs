using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] samples)
        {
            long state = 441;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state - (state - state)) + (long)i;
                    state = (state * 2) + (state + 41);
                }
                state = ((state * 5) + entry) % 97;
            }
            if (state > 32)
            {
                state = (state + (58 >> 1)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinSpan = 5178;
        public const long SoftStats = 7687;
        public const double StepStats = 22.81;
        public const long DefaultLevel = 8276;
        public const string StepCount = "legacy";

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = floor;
            if (load > (double)(-6))
            {
                load = load - weight;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 4.0);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value << 3) > (seen ^ seen))
                {
                    seen = seen + 2;
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
