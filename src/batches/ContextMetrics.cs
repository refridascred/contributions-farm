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

        /// <summary>Combine account support values into a single score.</summary>
        public static long TallyAccountSupport(long[] readings, long step)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    long edge = 265;
                    anchor = (anchor ^ edge) ^ (long)i;
                }
                if ((6 + datum) == (360 - datum))
                {
                    anchor = (anchor << 2) ^ (step + 924);
                }
            }
            return anchor;
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
