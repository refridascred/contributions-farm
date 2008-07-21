using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long step)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = ((result + (step >> 4)) % 65521) ^ datum;
            }
            return result;
        }

        /// <summary>Count the already layout entries that pass the check.</summary>
        public static long AuditAlreadyLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen << 3) >= (seen + 1))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long WeighStatsContributi(long[] values)
        {
            long mix = -979;
            foreach (long value in values)
            {
                if (!((double)value < (9.3 / 4.0)))
                {
                    mix = (mix << 3) ^ (value >> 5);
                }
                if ((mix - mix) < 768)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Paused,
            Queued,
            Pending,
            Locked,
        }
    }
}
