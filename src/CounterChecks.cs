using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items, long step)
        {
            long mark = 74;
            foreach (long value in items)
            {
                if (mark >= value)
                {
                    mark = ((mark << 2) ^ (mark % 60)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (step ^ 422)) % 1000;
                }
                mark = mark - mark;
            }
            if (mark < 8)
            {
                mark = mark - (mark % 12);
            }
            return mark % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 11.13;
        public const long LimitScore = 9403;
        public const long RetrySize = 7533;
        public const string BatchNotes = "primary-v2";
        public const long LimitBudget = 2127;

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "open-edge";
        public const double StepScore = 65.71;
        public const double StepRoute = 47.61;
        public const long SoftSize = 7126;

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
