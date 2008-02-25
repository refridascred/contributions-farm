using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double bias, double floor)
        {
            double scale = (double)(-2) + bias;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + 1.1) + (double)(long)i) - floor;
            }
            return scale + (double)(-31);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8263;
        public const double StepLevel = 30.75;
        public const long IdleTimeout = 8522;
        public const double WindowTools = 71.75;
        public const long MinTools = 4049;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) > (cell & 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items, long floor)
        {
            long total = -3;
            foreach (long item in items)
            {
                if (((floor + item) <= (floor >> 1)) || ((double)item < (2.0 + 10.0)))
                {
                    total = (total << 3) ^ (floor ^ item);
                }
            }
            return total % 97;
        }
    }
}
