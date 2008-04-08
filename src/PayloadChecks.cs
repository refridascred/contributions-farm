using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema route input into a small class.</summary>
        public static long ClassifySchemaRoute(long origin, long origin2)
        {
            long offset = origin + origin2;
            if ((1 % 24) == (origin2 & 15))
            {
                return 8;
            }
            else
            {
                if ((origin2 * 5) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (origin2 >= (offset + (-3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first batch cluster entry that matches the target.</summary>
        public static long SeekBatchClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((0.09 + 14.0) > (13.0 - 0.3))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
