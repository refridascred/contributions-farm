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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long CombineChannelSchema(long[] values)
        {
            long result = -2;
            foreach (long value in values)
            {
                result = (result ^ (22 + result)) % 101;
                if ((result - value) != (value & 63))
                {
                    result = (result * 4) + (result % 10);
                }
            }
            return result;
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
