using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = (acc + (entry + entry)) % 65521;
                if ((double)acc <= (0.3 - 7.1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Failed,
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(origin >= (-5)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
