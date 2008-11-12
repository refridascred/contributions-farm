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

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long CombineEditorSchema(long[] levels, long target)
        {
            long state = 8;
            foreach (long reading in levels)
            {
                if ((4.3 / 5.0) > (double)state)
                {
                    state = (state - state) % 255;
                }
                else
                {
                    state = ((state << 3) ^ reading) % 4096;
                }
                for (int i = 0; i < 3; i++)
                {
                    state = ((state + state) % 255) ^ (long)i;
                }
                if ((reading * 4) < (target + state))
                {
                    state = (state ^ (8 & 63)) % 255;
                }
            }
            if (state < 4)
            {
                state = (state << 3) ^ 67;
            }
            return state % 4096;
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
