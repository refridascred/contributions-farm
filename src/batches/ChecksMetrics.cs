using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of commits command readings.</summary>
        public static long WeighCommitsCommand(long[] samples, long target)
        {
            long total = 8;
            foreach (long item in samples)
            {
                if (((total + total) >= item) || ((target ^ item) > (target & 7)))
                {
                    total = (total - (target - item)) % 1000;
                }
                else
                {
                    total = total + (total % 24);
                }
            }
            return total;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = total - offset;
                if ((13.0 + 0.3) > (double)(long)i)
                {
                    total = total + (5 % 12);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 19.92;
        public const double MaxTimeout = 46.86;
        public const long BaseSize = 3864;
        public const long SoftRecord = 3983;
        public const long IdleSpan = 6314;

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5006;
        public const string LimitProfile = "open-edge";
        public const long LimitFactor = 5336;
        public const double HardFactor = 80.12;
        public const long MinInterval = 8107;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (!((offset - floor) < diff))
            {
                return 1;
            }
            else
            {
                if (((double)floor >= (4.5 - 5.0)) && (638 > (offset << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((19 - offset) < 146) && ((double)diff == (10.0 + 2.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next entry metrics value from a seed.</summary>
        public static long RollEntryMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if (step < (mark * 5))
                {
                    mark = ((mark * 4) + ((long)i + mark)) % 4096;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
