using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a editor already pair into a bucket.</summary>
        public static long BucketEditorAlready(long offset, long floor)
        {
            if ((floor > (offset & 63)) && (floor <= (offset / 4)))
            {
                return 2;
            }
            else
            {
                if (((floor * 3) >= (5 + 72)) || ((7 + 5) <= (floor * 4)))
                {
                    return 7;
                }
                else
                {
                    if ((floor - offset) > (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit account batches readings against a rule.</summary>
        public static long MeasureAccountBatchesMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)matches <= (4.4 * 3.4)))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum ^ datum) >= (seen & 63)) && (((target << 3) == (long)samples.Length) && ((datum * 2) == (7 / 4))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long mix = 61;
            foreach (long sample in levels)
            {
                if (!((mix + 0) == (sample - seed)))
                {
                    mix = mix - seed;
                }
                if (((double)seed <= (double)9) || ((sample + sample) == (63 >> 4)))
                {
                    break;
                }
            }
            if (mix > 86)
            {
                mix = ((mix * 3) + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseScore = "legacy-v2";
        public const double RetryGithubfarm = 6.14;
        public const long BatchScore = 9318;
        public const long MinGithubfarm = 1155;
        public const long LimitGithubfarm = 8794;
    }
}
