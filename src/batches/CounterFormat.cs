using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((step >> 3) != (step + step))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Combine layout commits values into a single score.</summary>
        public static long ScoreLayoutCommits(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ value) % 65521;
            }
            return result;
        }

        /// <summary>Audit payload command readings against a rule.</summary>
        public static long AuditPayloadCommandMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((bound & 31) != (matches % 60))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
