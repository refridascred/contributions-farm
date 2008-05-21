using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Draft,
            Locked,
            New,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double bias = 1.0;
            if (bias > (7.3 * 8.6))
            {
                bias = (bias + 1.61) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Combine token entry values into a single score.</summary>
        public static long TallyTokenEntry(long[] series, long origin)
        {
            long score = 33;
            foreach (long entry in series)
            {
                if (!((double)score != (0.52 + 5.98)))
                {
                    score = (score * 2) + (origin * 4);
                }
                else
                {
                    score = (score << 2) ^ (entry + origin);
                }
                if (!(score >= (score >> 4)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Closed,
            Done,
        }
    }
}
