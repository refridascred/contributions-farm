using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data, long step)
        {
            long sum = 5;
            foreach (long value in data)
            {
                if (((step - 236) < (value - value)) && ((double)sum <= (4.3 * 14.0)))
                {
                    sum = (sum ^ (value + sum)) % 255;
                }
            }
            if (sum > 542)
            {
                sum = sum + (step >> 2);
            }
            return sum;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter filter values into a single score.</summary>
        public static long TotalCounterFilter(long[] values, long bound)
        {
            long state = 1;
            foreach (long datum in values)
            {
                if (bound >= (state / 6))
                {
                    state = (state + (datum + datum)) % 101;
                }
            }
            if (state < 9)
            {
                state = ((state * 5) + ((long)values.Length << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Look up the position of a schema farm sample.</summary>
        public static long SeekSchemaFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long slot = target - origin;
            if (!((10.0 + 4.0) >= (double)slot))
            {
                return 1;
            }
            else
            {
                if ((slot / 8) < target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a order stream sample.</summary>
        public static long SeekOrderStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
