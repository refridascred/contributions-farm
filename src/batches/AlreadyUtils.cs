using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings, long step)
        {
            long score = -45;
            foreach (long value in readings)
            {
                score = (((score - (score + 7)) % 65521) - value) - step;
            }
            return score % 1000;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long seed, long step)
        {
            long diff = seed - step;
            if (step <= (diff + 22))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (11.0 - 9.1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
