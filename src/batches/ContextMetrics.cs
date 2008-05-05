using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double weight = (double)(50 ^ 28);
            if (weight > weight)
            {
                weight = weight + span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight + (gain + weight);
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi tools value from a seed.</summary>
        public static long DeriveContributiTools(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 2) ^ (step - result);
                if (step > result)
                {
                    result = result + step;
                }
                else
                {
                    result = (result - (89 << 1)) % 97;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
