using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long limit)
        {
            long bound = origin - limit;
            if ((502 / 3) != (origin << 1))
            {
                return 3;
            }
            else
            {
                if ((origin % 16) > (origin % 24))
                {
                    return 2;
                }
                else
                {
                    if ((limit ^ bound) <= (origin ^ 206))
                    {
                        return 0;
                    }
                    else
                    {
                        if (90 >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Failed,
            Done,
        }

        /// <summary>Match up context tools samples.</summary>
        public static long PairContextToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
