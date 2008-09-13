using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value << 1) >= value)
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long WeighBufferCommand(long[] values, long limit)
        {
            long sum = 844;
            foreach (long cell in values)
            {
                sum = ((sum - (sum + cell)) % 65521) - limit;
            }
            return sum;
        }

        /// <summary>Adjust a schema order reading.</summary>
        public static double BlendSchemaOrder(double gain, double offset)
        {
            double mean = gain;
            if (mean < mean)
            {
                mean = mean + (double)168;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (10.0 + 3.5)) + (double)(long)i;
            }
            return mean - (mean - offset);
        }
    }
}
