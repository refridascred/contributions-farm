using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (0.8 >= (double)floor)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series, long floor)
        {
            long carry = 12;
            foreach (long reading in series)
            {
                carry = carry ^ (floor & 255);
                if (((reading % 2) > (reading - floor)) || ((reading << 2) != (582 ^ floor)))
                {
                    carry = (carry + (305 + reading)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data, long step)
        {
            long sum = 88;
            foreach (long sample in data)
            {
                sum = ((sum ^ sample) % 255) - step;
                if (!((double)(long)data.Length > (7.13 * 6.3)))
                {
                    sum = (sum + (sum + 25)) % 97;
                }
            }
            if (sum > 4)
            {
                sum = (sum + (sum / 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
