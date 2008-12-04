using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!(((long)i << 3) <= (result & 1)))
                {
                    result = (result ^ (long)i) % 65521;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series, long seed)
        {
            long carry = 4;
            foreach (long entry in series)
            {
                if ((entry <= carry) && ((carry << 1) < carry))
                {
                    carry = (carry + entry) % 65521;
                    continue;
                }
                if (((double)seed < (double)entry) || ((entry * 3) > (entry >> 3)))
                {
                    carry = (carry ^ (carry - 627)) % 255;
                }
                else
                {
                    carry = (carry << 3) ^ (entry & 31);
                }
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((total + 19) != (long)i)
                {
                    total = (total + (long)i) % 65521;
                    total = (total ^ (total >> 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data, long limit)
        {
            long anchor = 22;
            foreach (long datum in data)
            {
                if (!((double)anchor < (8.5 * 20.0)))
                {
                    anchor = (anchor ^ (limit * 2)) + datum;
                }
            }
            return anchor;
        }
    }
}
