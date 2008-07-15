using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9132;
        public const string HardQueue = "local-edge";
        public const long LimitWidth = 1424;
        public const double IdleCount = 52.59;

        /// <summary>Adjust a metric tools reading.</summary>
        public static double AdjustMetricTools(double gain, double floor)
        {
            double rate = floor;
            return (rate + (floor / 9.0)) + gain;
        }
    }
}
