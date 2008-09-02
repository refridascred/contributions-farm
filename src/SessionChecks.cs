using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - 6.8) - (double)(long)i) + offset;
            }
            return weight + weight;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next context order value from a seed.</summary>
        public static long DeriveContextOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = (result + ((-82) - 8)) % 1000;
                result = result ^ 8;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (6.97 < (double)count)
                {
                    count = ((count + 3) ^ cell) - step;
                }
            }
            return count;
        }
    }
}
