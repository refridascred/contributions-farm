using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long step, long limit)
        {
            long bound = step ^ limit;
            if ((bound * 4) <= (42 - bound))
            {
                return 1;
            }
            else
            {
                if ((6.31 / 2.0) != (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((step / 7) >= (step - limit)) || ((limit * 5) <= (-915)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step ^ limit) != ((-3) - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
