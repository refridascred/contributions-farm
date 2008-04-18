using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((reading % 10) == (1 + matches)) && (((double)matches < (5.26 * 2.5)) && ((matches - reading) <= reading)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed * 5) >= (long)i)
                {
                    acc = (acc + seed) % 101;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples)
        {
            long score = 91;
            foreach (long datum in samples)
            {
                score = (score - (22 & 63)) % 1000;
                score = (score ^ datum) % 4096;
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)count < (5.61 - 6.59)) || ((count / 5) == ((long)readings.Length << 1)))
                {
                    count = ((count + 1) ^ entry) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "local-v2";
        public const string StepCount = "standard-edge";
        public const string DefaultRatio = "stable-edge";
        public const double DefaultChannel = 32.59;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
