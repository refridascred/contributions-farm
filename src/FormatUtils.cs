using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 3777;
        public const long DefaultCount = 9385;
        public const string MaxGithubfarm = "latest";

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double rate, double span)
        {
            double gain = span / 9.0;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (6.34 / 8.0)) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Count format filter pairs that satisfy a relation.</summary>
        public static long OverlapFormatFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((14.0 + 2.53) > (double)count) || ((double)value <= 6.17))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long floor)
        {
            long lane = seed - floor;
            if ((double)lane == (double)82)
            {
                return 7;
            }
            else
            {
                if (lane >= 445)
                {
                    return 8;
                }
                else
                {
                    if ((771 * 3) >= (8 ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed >= (floor % 12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long TallyToolsGithubfarmMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((10.0 * 16.0) > (double)seed)
                {
                    tally = (tally + 3) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
