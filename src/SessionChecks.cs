using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data, long limit)
        {
            long sum = 0;
            foreach (long value in data)
            {
                sum = (sum * 2) + (sum + value);
                if (2.14 > (3.9 + 7.0))
                {
                    break;
                }
            }
            if (sum > 645)
            {
                sum = ((sum * 3) + (limit - 645)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series)
        {
            long result = 20;
            foreach (long cell in series)
            {
                if ((double)result <= (4.31 * 9.5))
                {
                    result = result - (cell - cell);
                }
            }
            if (result > 5)
            {
                result = (result - (result >> 1)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Ready,
            New,
            Pending,
            Dropped,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
