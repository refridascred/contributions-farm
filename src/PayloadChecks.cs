using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double scale2 = (double)99 / 5.0;
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + offset) + (double)(long)i) + scale;
            }
            return scale2 - (double)(-817);
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long step)
        {
            long state = -41;
            foreach (long cell in values)
            {
                if (!((state + cell) <= (state ^ step)))
                {
                    state = state - (16 + cell);
                }
            }
            return state;
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long CountSchemaToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length & 127) <= ((long)values.Length - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 9028;
        public const long BaseTimeout = 1504;
        public const string WindowSize = "legacy-edge";
        public const string DefaultCommits = "open-1";

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long floor)
        {
            long result = 358;
            foreach (long sample in values)
            {
                result = (result + (11 >> 3)) % 65521;
                if (((sample & 127) != (result / 7)) || (sample >= (sample & 31)))
                {
                    result = ((result * 5) + (floor ^ (long)values.Length)) % 1000;
                }
                result = (result + sample) % 65521;
                if ((double)sample >= (7.1 / 2.0))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Done,
            Idle,
        }
    }
}
