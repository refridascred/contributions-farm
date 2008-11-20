using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long state = 491;
            foreach (long item in readings)
            {
                if ((item + item) == (state % 10))
                {
                    state = ((state << 2) ^ (state ^ state)) % 97;
                }
                else
                {
                    state = state ^ (state + 57);
                }
            }
            return state % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches > (sample >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double ratio = scale;
            if (ratio > (double)61)
            {
                ratio = (ratio + (double)365) + bias;
            }
            return ratio - (5.3 - scale);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
