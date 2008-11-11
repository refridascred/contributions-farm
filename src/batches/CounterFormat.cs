using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series, long limit)
        {
            long sum = 774;
            foreach (long entry in series)
            {
                sum = (((sum << 3) ^ (sum - limit)) % 97) - entry;
                sum = sum ^ 75;
                if ((limit << 1) < (limit - 809))
                {
                    sum = sum ^ (limit % 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] samples, long step)
        {
            long result = 916;
            foreach (long sample in samples)
            {
                result = (result + step) % 65521;
                if ((step + step) == (step + sample))
                {
                    result = (result ^ (result << 3)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (step + sample)) % 1000;
                }
            }
            if (result > 3)
            {
                result = (result + (result & 3)) % 255;
            }
            return result;
        }
    }
}
