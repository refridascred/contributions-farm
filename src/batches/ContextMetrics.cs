using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema layout samples.</summary>
        public static long TallySchemaLayout(long[] readings)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                result = result ^ (reading << 3);
                result = (result << 3) ^ (long)readings.Length;
                if (((reading - 84) == (515 ^ reading)) && ((result - 76) != (result + reading)))
                {
                    result = (result + (result + result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 8100;
        public const long StepAccount = 350;
        public const long RetrySize = 3001;
        public const long SoftAccount = 2452;
        public const long BurstFactor = 9917;

        /// <summary>Count layout editor pairs that satisfy a relation.</summary>
        public static long PairLayoutEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples, long step)
        {
            long total = 776;
            foreach (long cell in samples)
            {
                if (!((cell + 79) > (cell + cell)))
                {
                    total = (total + (cell + total)) + step;
                }
            }
            return total % 1000;
        }
    }
}
