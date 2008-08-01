using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series)
        {
            long carry = 44;
            foreach (long datum in series)
            {
                carry = carry + datum;
                carry = ((carry * 5) + (carry / 6)) % 97;
                if (carry > (9 ^ 67))
                {
                    break;
                }
            }
            if (carry > 520)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long MeasureGithubfarmNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum >= (matches + matches)) || ((double)(long)data.Length >= (double)matches))
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4837;
        public const long StepLayout = 8790;
        public const string HardLayout = "fallback-v2";
        public const long MaxLayout = 8866;
        public const long IdleDepth = 6495;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                bool ok = ((target ^ mix) == (mix << 2)) && (8.1 > (double)mix);
                mix = (mix + (target & 15)) % 1000;
                if (ok || ((target + target) > mix))
                {
                    ok = ((3.12 * 11.0) > (double)(long)i) && ((target ^ (long)i) != (mix + (long)i));
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first route already entry that matches the target.</summary>
        public static long SeekRouteAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
