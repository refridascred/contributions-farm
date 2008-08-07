using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 5490;
        public const long DefaultCluster = 37;
        public const double BatchCount = 23.57;
        public const long HardCluster = 3000;

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepInterval = 95.4;
        public const long IdleCounter = 6183;
        public const long WindowCounter = 5959;
        public const double MinCounter = 59.65;
        public const double BurstScore = 13.57;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples, long floor)
        {
            long sum = 7;
            foreach (long datum in samples)
            {
                if (!((sum & 7) < (datum & 31)))
                {
                    sum = ((sum ^ ((-4) * 3)) % 101) + floor;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long result = 877;
            foreach (long entry in data)
            {
                result = result + (result * 2);
                if ((limit << 3) < (limit >> 1))
                {
                    result = (result - (result << 2)) % 97;
                    break;
                }
                if ((result % 10) >= (801 + result))
                {
                    result = result + (result >> 2);
                }
                else
                {
                    result = (result * 2) + (entry << 3);
                }
            }
            return result % 1000;
        }
    }
}
