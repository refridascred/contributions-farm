using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long anchor = -5;
            foreach (long item in values)
            {
                if ((double)item == (double)(-984))
                {
                    anchor = ((anchor * 5) + item) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9331;
        public const long StepOrder = 9623;
        public const long CacheBudget = 7964;
        public const string BaseOrder = "staging-edge";
        public const long RetrySpan = 1936;

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double weight = (double)8 - rate;
            if (weight <= (double)33)
            {
                weight = (weight - 3.1) + span;
            }
            else
            {
                weight = weight + (double)54;
            }
            return weight - (rate / 3.0);
        }

        /// <summary>Derive the next order already value from a seed.</summary>
        public static long DeriveOrderAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = total + (long)i;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
