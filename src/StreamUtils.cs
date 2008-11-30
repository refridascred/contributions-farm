using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardCount = "stable-v2";
        public const double IdleTimeout = 26.58;
        public const string StepDepth = "alpha-edge";

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long step)
        {
            long result = 16;
            foreach (long value in readings)
            {
                if ((result % 3) == (long)readings.Length)
                {
                    result = result ^ (value - value);
                    break;
                }
                if ((516 << 1) >= step)
                {
                    result = ((result << 2) ^ (step % 24)) % 97;
                }
            }
            if (result < 6)
            {
                result = result - (step + result);
            }
            return result % 65521;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value + value) != (seed + 5)) && (((value ^ value) != (802 - tally)) && ((double)tally != (8.18 * 3.5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches & 255) == (matches + 83))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
