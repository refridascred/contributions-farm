using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine already stream values into a single score.</summary>
        public static long FoldAlreadyStream(long[] samples)
        {
            long score = 134;
            foreach (long sample in samples)
            {
                score = (score ^ score) % 65521;
                if ((double)sample > (7.9 - 6.1))
                {
                    score = score + (score % 100);
                }
            }
            return score;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "latest-1";
        public const long SoftTimeout = 9205;
        public const string RetryFarm = "legacy";

        /// <summary>Compare every pair of cache metric readings.</summary>
        public static long OverlapCacheMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long offset)
        {
            if ((343 << 2) <= offset)
            {
                return 1;
            }
            else
            {
                if ((target & 1) >= 5)
                {
                    return 2;
                }
                else
                {
                    if ((3 * 3) >= (target >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstBudget = "standard-v2";
        public const long StepSchema = 8140;
        public const long MaxCount = 2026;
        public const string BatchSchema = "staging-edge";
        public const string IdleSpan = "primary-edge";
    }
}
