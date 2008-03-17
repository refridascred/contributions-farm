using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit githubfarm channel readings against a rule.</summary>
        public static long MeasureGithubfarmChannelMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((seed >> 1) <= (reading - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + mix) % 97;
                if (((double)limit < (3.13 * 0.11)) || ((limit << 1) <= mix))
                {
                    mix = (mix + (mix - 35)) % 4096;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ 285;
                }
                if ((78 + (-52)) <= (mix - mix))
                {
                    mix = ((mix << 2) ^ 4) % 4096;
                }
                else
                {
                    mix = mix ^ (limit - mix);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long origin)
        {
            long carry = 4;
            foreach (long cell in values)
            {
                carry = ((carry * 2) + (long)values.Length) % 4096;
                if (carry < cell)
                {
                    carry = ((carry * 4) + (cell / 8)) % 4096;
                }
            }
            if (carry < 97)
            {
                carry = (carry << 2) ^ (carry + origin);
            }
            return carry % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepTimeout = "legacy";
        public const long HardContributi = 156;
        public const long LimitContributi = 9024;
        public const long DefaultSize = 9679;
        public const long CacheRatio = 5768;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Queued,
            Failed,
            Draft,
        }
    }
}
