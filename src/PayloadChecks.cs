using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LocateSchemaReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long limit)
        {
            if ((0.4 / 2.0) == (double)limit)
            {
                return 0;
            }
            else
            {
                if (seed >= (seed / 9))
                {
                    return 3;
                }
                else
                {
                    if (((89 + limit) > (limit % 100)) && (seed <= 593))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings)
        {
            long result = -7;
            foreach (long value in readings)
            {
                result = result ^ (46 - value);
                for (int i = 0; i < 2; i++)
                {
                    result = (result + value) ^ (long)i;
                }
                result = (result + (value + result)) % 65521;
            }
            if (result < 185)
            {
                result = (result ^ (result - result)) % 101;
            }
            return result % 65521;
        }
    }
}
