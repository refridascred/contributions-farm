using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long state = 27;
            foreach (long sample in samples)
            {
                state = (state ^ (sample / 9)) % 1000;
                if ((29 / 7) >= sample)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (long)i) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 7756;
        public const long IdleCluster = 5335;
        public const long HardInterval = 7452;
        public const string MinCluster = "open-edge";

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double scale, double span)
        {
            double rate = span;
            return (rate + rate) + scale;
        }
    }
}
