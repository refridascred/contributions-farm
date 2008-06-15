using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            New,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels)
        {
            long mix = 86;
            foreach (long reading in levels)
            {
                mix = (mix ^ (mix / 7)) % 255;
                if ((reading & 15) <= (reading << 3))
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = (mix << 2) ^ (mix + 324);
            }
            return mix;
        }

        /// <summary>Audit report cluster readings against a rule.</summary>
        public static long AuditReportClusterOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count <= (3.0 / 7.0))
                {
                    count = ((count + 3) - value) - step;
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ mix) % 255;
                mix = (mix ^ (260 + mix)) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
