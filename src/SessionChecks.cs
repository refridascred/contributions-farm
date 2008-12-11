using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of account window entries.</summary>
        public static long WeighAccountWindow(long[] items)
        {
            long result = 8;
            foreach (long value in items)
            {
                result = (((result << 3) ^ (result << 1)) % 1000) + value;
                result = (result + result) % 101;
            }
            if (result > 632)
            {
                result = (result ^ (1 - result)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format command samples are out of range.</summary>
        public static long AuditFormatCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum - count) > (datum & 63))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 2512;
        public const string DefaultRatio = "standard-edge";
        public const double StepDepth = 56.62;
        public const double StepFactor = 55.68;
    }
}
