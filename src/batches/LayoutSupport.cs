using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long ScoreStatsAlready(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                result = ((result << 2) ^ (value - value)) % 97;
                if (((9.0 + 5.7) <= (double)result) || ((result % 100) >= result))
                {
                    result = (result + result) % 1000;
                }
            }
            if (result > 692)
            {
                result = (result + (result % 16)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long carry = -9;
            foreach (long value in levels)
            {
                carry = ((carry ^ (carry / 2)) % 65521) + value;
            }
            if (carry > 82)
            {
                carry = (carry << 3) ^ (carry & 31);
            }
            return carry;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
