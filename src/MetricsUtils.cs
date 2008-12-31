using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next token schema value.</summary>
        public static double BlendTokenSchema(double ratio, double floor)
        {
            double mean = (double)((-59) / 6);
            if (mean >= (double)75)
            {
                mean = (mean - ratio) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - (double)976;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                long diff = (-41) << 3;
                if (64 >= diff)
                {
                    mark = ((mark * 4) + ((-231) + 40)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many channel schema samples are out of range.</summary>
        public static long TallyChannelSchemaHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length - matches) <= bound)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a payload queue pair into a bucket.</summary>
        public static long ClassifyPayloadQueue(long limit, long target)
        {
            if ((limit ^ limit) > (limit % 100))
            {
                return 1;
            }
            else
            {
                if ((limit - target) < target)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
