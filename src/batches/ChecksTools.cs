using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 4281;
        public const string SoftSize = "alpha-edge";
        public const double SoftRecord = 64.64;
        public const long HardRecord = 256;
        public const double StepSpan = 71.64;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - count) < (step / 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values)
        {
            long sum = -7;
            foreach (long sample in values)
            {
                if (((long)values.Length != (3 - sample)) && (((long)values.Length ^ sum) <= 5))
                {
                    break;
                }
                else
                {
                    sum = (sum - (sum ^ 7)) % 101;
                    sum = (sum - (sum - sum)) % 255;
                }
                if ((sample % 97) <= (sample << 1))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = ((sum << 2) ^ ((long)values.Length - 405)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Match up tools buffer samples.</summary>
        public static long PairToolsBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
