using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi tools entries that pass the check.</summary>
        public static long AuditContributiToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8 - tally) > (tally ^ tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already session readings.</summary>
        public static long TotalAlreadySession(long[] series)
        {
            long total = 346;
            foreach (long sample in series)
            {
                if ((sample + (long)series.Length) > sample)
                {
                    total = (total * 2) + total;
                }
            }
            if (total > 70)
            {
                total = (total * 5) + (total << 1);
            }
            return total;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
