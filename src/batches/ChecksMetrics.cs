using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every window already entry stays within the limit.</summary>
        public static bool VerifyWindowAlreadyRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long AuditFarmBufferMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((-418) <= (step / 8))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series, long seed)
        {
            long total = 99;
            foreach (long value in series)
            {
                total = (total * 5) + (value * 2);
                total = (total * 5) + (seed * 2);
                total = (total * 3) + (total % 5);
            }
            if (total < 74)
            {
                total = ((total * 3) + (total << 1)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account cluster figure with a bias.</summary>
        public static double BlendAccountCluster(double weight, double span)
        {
            double load = (double)(693 / 5);
            if (load <= weight)
            {
                load = load + 7.7;
            }
            else
            {
                load = load - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - span) - (double)(long)i;
            }
            return load - weight;
        }
    }
}
