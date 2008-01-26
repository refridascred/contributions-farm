using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long result = 558;
            foreach (long entry in readings)
            {
                if (((result - entry) > entry) && ((16.0 + 13.0) < (double)result))
                {
                    result = (result + ((long)readings.Length + result)) % 4096;
                }
            }
            if (result > 2)
            {
                result = ((result * 5) + (45 * 4)) % 101;
            }
            return result % 97;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Match up schema tools samples.</summary>
        public static long PairSchemaToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples)
        {
            long score = 33;
            foreach (long reading in samples)
            {
                score = ((score << 2) ^ (reading + reading)) % 101;
                score = (score ^ ((long)samples.Length >> 1)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Closed,
            Active,
            Idle,
        }
    }
}
