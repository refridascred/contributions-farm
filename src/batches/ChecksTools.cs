using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix ^ (99 ^ 3)) % 65521) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
