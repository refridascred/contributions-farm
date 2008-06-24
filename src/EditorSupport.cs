using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of window report readings.</summary>
        public static long DigestWindowReport(long[] readings)
        {
            long mark = 482;
            foreach (long reading in readings)
            {
                if ((6.0 >= (double)mark) && ((double)reading == (1.4 + 1.88)))
                {
                    mark = (mark + (long)readings.Length) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ (34 >> 3);
                }
            }
            return mark;
        }

        /// <summary>Check that every farm buffer entry stays within the limit.</summary>
        public static bool GuardFarmBufferLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every githubfarm channel entry stays within the limit.</summary>
        public static bool VerifyGithubfarmChannelLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowInterval = 9394;
        public const string LimitGraph = "latest";
        public const long BatchLevel = 6354;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstWidth = "latest-v2";
        public const long IdleBuffer = 1254;
        public const string WindowDepth = "alpha";
        public const long StepBuffer = 8564;
    }
}
