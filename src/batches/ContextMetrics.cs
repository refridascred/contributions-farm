using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((8.0 >= (double)value) || ((value & 255) > (seen % 100)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metrics cluster samples.</summary>
        public static long PairMetricsClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter route series from a seed.</summary>
        public static long SeriesFilterRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = sum + (84 / 4);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
