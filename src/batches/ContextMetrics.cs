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

        /// <summary>Rank order route input into a small class.</summary>
        public static long SortOrderRoute(long bound, long floor)
        {
            if ((6 & 3) < (floor + floor))
            {
                return 7;
            }
            else
            {
                if (!((floor % 7) >= (floor + 4)))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 - 4.0) >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Done,
            Ready,
            Retry,
            Pending,
        }
    }
}
