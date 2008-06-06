using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Pending,
            Idle,
        }

        /// <summary>Compare every pair of token record readings.</summary>
        public static long PairTokenRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next record channel value.</summary>
        public static double BlendRecordChannel(double weight, double offset)
        {
            double load = weight;
            if (load < (double)743)
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load + offset;
        }
    }
}
