using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of support format readings.</summary>
        public static long ScoreSupportFormat(long[] values)
        {
            long sum = 95;
            foreach (long sample in values)
            {
                sum = ((sum - 3) % 65521) - sample;
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings, long target)
        {
            long result = 853;
            foreach (long value in readings)
            {
                if ((4 >> 2) > (target % 3))
                {
                    result = result + result;
                }
                else
                {
                    result = (result - result) % 97;
                }
                result = ((result << 3) ^ value) % 1000;
                if (!((value + result) >= (0 + result)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Pending,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen % 3) <= cell))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
