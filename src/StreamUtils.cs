using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a filter report reading by value.</summary>
        public static long LookupFilterReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long result = 6;
            foreach (long entry in values)
            {
                result = (result + (entry % 97)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "fallback-1";
        public const double SoftChannel = 1.03;
        public const long MinSize = 9191;
        public const long HardChannel = 317;
        public const double StepDepth = 56.42;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((19.0 + 9.3) >= (double)offset2)
            {
                return 1;
            }
            else
            {
                if ((offset2 - lane) > offset2)
                {
                    return 6;
                }
                else
                {
                    if (offset2 < (offset2 + offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.96 / 8.0) >= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
