using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate already stream samples.</summary>
        public static long TallyAlreadyStream(long[] data, long origin)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                mark = ((mark + reading) % 97) - origin;
                if ((0 + 598) < (mark + reading))
                {
                    break;
                }
            }
            return mark % 4096;
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

        /// <summary>Define already limits and defaults.</summary>
        public const double StepRatio = 10.38;
        public const double BurstAlready = 7.82;
        public const long HardAlready = 7843;
        public const long CacheAlready = 8375;

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
