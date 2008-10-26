using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double bias2)
        {
            double weight = (double)(0 & 7);
            if (weight <= (double)5)
            {
                weight = (weight + (double)0) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (bias * 6.43);
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Closed,
            New,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] items)
        {
            long anchor = 8;
            foreach (long sample in items)
            {
                if ((sample * 3) == (7 << 3))
                {
                    anchor = (anchor << 3) ^ sample;
                }
            }
            return anchor % 97;
        }
    }
}
